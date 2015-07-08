using SistemaFacturacionDesk.Busquedas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacionDesk
{
    public partial class frmFacturacion : Form
    {

        EntitiesFACTURACION db = new EntitiesFACTURACION();
        private static Dictionary<int, int> ArticulosFacturados = new Dictionary<int, int>();
        public frmFacturacion()
        {
            InitializeComponent();
        }

        private void frmFacturacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Visible = true;
            this.Dispose();
        }

        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            LimpiarControlesClientes();
        }

        #region Proceso Cliente
        public void SetearCliente(int IdCliente)
        {
            var cliente = db.CLIENTES.Find(IdCliente);

            idTextBox.Text = cliente.id.ToString();
            nombreComercialTextBox.Text = cliente.nombreComercial;
            razonSocialTextBox.Text = cliente.razonSocial;
            rNC_CEDTextBox.Text = cliente.RNC_CED;
            telefonoTextBox.Text = cliente.telefono;
            emailTextBox.Text = cliente.email;
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBusquedaCliente formBuscarCliente = new frmBusquedaCliente();
            formBuscarCliente.Visible = true;
            formBuscarCliente.Owner = this;
        }

        private void LimpiarControlesClientes()
        {
            idTextBox.Text = string.Empty;
            nombreComercialTextBox.Text = string.Empty;
            razonSocialTextBox.Text = string.Empty;
            rNC_CEDTextBox.Text = string.Empty;
            telefonoTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            LimpiarControlesClientes();
        }

        #endregion


        #region Proceso Articulos

        private void AgregarArticulo(int IdArticulo, int CantidadArticuloFacturar)
        {
            if (CantidadArticuloFacturar > 0)
            {
                var articulo = db.ARTICULOS.Find(IdArticulo);

                if (ArticulosFacturados.ContainsKey(articulo.id))
                {
                    ArticulosFacturados[articulo.id] += CantidadArticuloFacturar;
                }
                else
                {
                    ArticulosFacturados.Add(articulo.id, CantidadArticuloFacturar);
                }

                articulo.stock -= CantidadArticuloFacturar;
                db.SaveChanges();
                CargarGridArticulosFacturados();
            }
            else {
                this.MensajeAdvertencia("No se agregó el artículo, cantidad = 0");
            }
        }

        private void RemoverArticulo(int IdArticulo)
        {
            var articulo = db.ARTICULOS.Find(IdArticulo);
            if (ArticulosFacturados.ContainsKey(articulo.id))
            {
                articulo.stock += ArticulosFacturados[articulo.id];
                ArticulosFacturados.Remove(articulo.id);
            }

            db.SaveChanges();
            CargarGridArticulosFacturados();

        }

        private void CargarGridArticulosFacturados()
        {
            var dsArticulosFacturados = (from af in ArticulosFacturados
                                         from a in db.ARTICULOS
                                         where a.id == af.Key
                                         select new
                                         {
                                             a.id,
                                             a.descripcion,
                                             categoria = a.CATEGORIA.descripcion,
                                             a.precioUnitario,
                                             cantidadArticulo = af.Value,
                                             importe = a.precioUnitario * af.Value
                                         });


            aRTICULOSDataGridView.DataSource = dsArticulosFacturados.ToList();

        }

        private void btnAgregarArticulos_Click(object sender, EventArgs e)
        {
            frmBusquedaArticulo formBusquedaArticulo = new frmBusquedaArticulo();
            formBusquedaArticulo.Visible = true;
            formBusquedaArticulo.Owner = this;

        }

        public void SetearArticulo(int IdArticulo)
        {
            string cantidadArticulo = "";

            #region Obtener Cantidad de Articulos

            do
            {
                cantidadArticulo = Microsoft.VisualBasic.Interaction.InputBox("", "Cantidad de Articulos", "0");
                //if (!int.TryParse(cant, out cantidadArticulo))
                //{
                //    this.MensajeAdvertencia("Datos incorrectos, intentar nuevamente! ");
                //    cant = string.Empty;
                //}

                if (ValidarArticuloFacturar(IdArticulo, cantidadArticulo))
                {
                    AgregarArticulo(IdArticulo, int.Parse(cantidadArticulo));
                }

            } while (string.IsNullOrEmpty(cantidadArticulo));
            #endregion




        }

        private bool ValidarArticuloFacturar(int idArticulo, string CantidadArticulos)
        {
            bool valido = true;
            int cantArti = 0;
            string message = "";

            if (idArticulo <= 0)
            {
                message = "El artículo especificado no es valido, favor de verificar !!";
                valido = false;
            }
            else if (db.ARTICULOS.Find(idArticulo) == null)
            {
                message = "El artículo especificado no existe, favor de verificar !!";
                valido = false;
            }
            else if (!int.TryParse(CantidadArticulos, out cantArti))
            {
                message = "Debe especificar la cantidad que va a facturar de este artículo.";
                valido = false;
            }

            int ArticuloStock = db.ARTICULOS.Find(idArticulo).stock;
            if (cantArti > ArticuloStock)
            {
                message = string.Format("La cantidad de artículos insertada no esta dísponible solo hay {0} en existencia, favor de verificar!!!", ArticuloStock);
                valido = false;
            }

            if (!valido) { this.MensajeAdvertencia(message); }

            return valido;
        }
        /*

        private void RealizarCalculos()
        {
            float totalBruto = float.Parse(txtTotalBruto.Text);
            float PorcentajeDescuento = float.Parse(txtPorcentajeDescuento.Text);
            float PorcentajeITBIS = float.Parse(txtPorcentajeITBIS.Text);

            var dsArticulosFacturados = (from af in ArticulosFacturados
                                         from a in db.ARTICULOS
                                         where a.id == af.Key
                                         select new
                                         {
                                             a.id,
                                             a.descripcion,
                                             categoria = a.CATEGORIA.descripcion,
                                             a.precioUnitario,
                                             cantidadArticulo = af.Value,
                                             importe = a.precioUnitario * af.Value
                                         });


            #region Bruto
            txtTotalBruto.Text = dsArticulosFacturados.Sum(a => a.importe).ToString();
            totalBruto = int.Parse(txtTotalBruto.Text);
            #endregion

            #region Descuento
            txtDescuento.Text = (totalBruto * (PorcentajeDescuento / 100)).ToString();
            #endregion

            #region ITBIS
            txtITBIS.Text = (totalBruto * (PorcentajeITBIS / 100)).ToString();
            #endregion

            #region Total
            txtTotalNeto.Text = (totalBruto - (totalBruto * (PorcentajeDescuento / 100)) + (totalBruto * (PorcentajeITBIS / 100))).ToString(); ;
            #endregion
        }
         
          private void LimpiarArticulosFacturados()
        {
            foreach (var item in ArticulosFacturados)
            {
                if (ArticulosFacturados.ContainsKey(item.Key))
                {
                    db.ARTICULOS.Find(item.Key).stock += ArticulosFacturados[item.Key];
                }
            }
            ArticulosFacturados.Clear();
            db.SaveChanges();
        }

           protected void btnGuardarFacturar_Click(object sender, EventArgs e)
        {
            if (ValidatarDatosFactura())
            {
                try
                {
                    using (TransactionScope trans = new TransactionScope())
                    {   
                        FACTURAS factura = new FACTURAS();
                        DETALLE_FACTURA detalleFactura = new DETALLE_FACTURA();

                        factura.comentario = txtComentario.Text;
                        factura.fechaRegistro = DateTime.Now;
                        factura.idCondicionPago = int.Parse(ddlCondicionPago.SelectedValue);
                        factura.idVendedor = int.Parse(hdfIdVendedor.Value);
                        factura.idCliente = int.Parse(hdfIdCliente.Value);
                        factura.PorcentajeDescuento = int.Parse(string.IsNullOrEmpty(txtPorcentajeDescuento.Text) ? "0" : txtPorcentajeDescuento.Text);
                        factura.ITBIS = int.Parse(string.IsNullOrEmpty(txtPorcentajeITBIS.Text) ? "0" : txtPorcentajeITBIS.Text);
                        db.FACTURAS.Add(factura);

                        foreach (var articuloFacturado in ArticulosFacturados)
                        {
                            detalleFactura.idArticulo = articuloFacturado.Key;
                            detalleFactura.idFactura = factura.id;
                            detalleFactura.precioUnitario = db.ARTICULOS.Find(articuloFacturado.Key).precioUnitario;
                            detalleFactura.cantidad = articuloFacturado.Value;
                            db.DETALLE_FACTURA.Add(detalleFactura);
                        }

                        db.SaveChanges();
                        LimpiarCamposFactura();
                        trans.Complete();
                        message.type = "success";
                        message.text = string.Format("Factura registrada. No. {0}", factura.id);
                        this.ShowMessage(message);


                    }

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {

                }
            }
        }
         
         
         
         
         */
        #endregion
    }
}
