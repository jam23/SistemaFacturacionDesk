using SistemaFacturacionDesk.Busquedas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace SistemaFacturacionDesk
{
    public partial class frmFacturacion : Form
    {

        EntitiesFACTURACION db = new EntitiesFACTURACION();
        private static Dictionary<int, int> ArticulosFacturados = new Dictionary<int, int>();
        frmBusquedaArticulo formBusquedaArticulo = new frmBusquedaArticulo();
        frmBusquedaCliente formBuscarCliente = new frmBusquedaCliente();

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
            // TODO: This line of code loads data into the 'fACTURACIONDataSet.CONDICIONESPAGO' table. You can move, or remove it, as needed.
            this.cONDICIONESPAGOTableAdapter.Fill(this.fACTURACIONDataSet.CONDICIONESPAGO);
            RealizarCalculos();
            LimpiarControlesClientes();
            txtVendedor.Text = User.UsuarioLogeado.NombreCompleto;
            this.txtPorcentajeDescuento.ValidarContenido(TipoDatos.Numerico);
        }

        #region Proceso Cliente
        public void SetearCliente(int IdCliente)
        {
            var cliente = db.CLIENTES.Find(IdCliente);

            idTextBoxCliente.Text = cliente.id.ToString();
            nombreComercialTextBox.Text = cliente.nombreComercial;
            razonSocialTextBox.Text = cliente.razonSocial;
            rNC_CEDTextBox.Text = cliente.RNC_CED;
            telefonoTextBox.Text = cliente.telefono;
            emailTextBox.Text = cliente.email;
        }


        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            formBuscarCliente.Visible = true;
            formBuscarCliente.Owner = this;
        }

        private void LimpiarControlesClientes()
        {
            idTextBoxCliente.Text = string.Empty;
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
            else
            {
                this.MensajeAdvertencia("No se agregó el artículo, cantidad = 0");
            }
        }

        private bool RemoverArticulo(int IdArticulo)
        {
            var articulo = db.ARTICULOS.Find(IdArticulo);
            if (ArticulosFacturados.ContainsKey(articulo.id))
            {
                articulo.stock += ArticulosFacturados[articulo.id];
                ArticulosFacturados.Remove(articulo.id);
            }
            else
            {
                return false;
            }

            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
                throw;
            }

            CargarGridArticulosFacturados();
            return true;

        }

        private void CargarGridArticulosFacturados()
        {
            var dsArticulosFacturados = (from af in ArticulosFacturados
                                         from a in db.ARTICULOS
                                         where a.id == af.Key
                                         select new
                                         {
                                             Id = a.id,
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
            formBusquedaArticulo.Visible = true;
            formBusquedaArticulo.Owner = this;

        }

        public void SetearArticulo(int IdArticulo)
        {
            string cantidadArticulo = "";
            int validCantidad = 0;
            #region Obtener Cantidad de Articulos

            do
            {
                cantidadArticulo = Microsoft.VisualBasic.Interaction.InputBox("", "Cantidad de Articulos", "0");
                if (string.IsNullOrEmpty(cantidadArticulo) || cantidadArticulo == "0") { formBusquedaArticulo.Visible = true; return; }

                if (ValidarArticuloFacturar(IdArticulo, cantidadArticulo))
                {
                    AgregarArticulo(IdArticulo, int.Parse(cantidadArticulo));
                    formBusquedaArticulo.Visible = false;
                    this.Focus();
                }

            } while (!int.TryParse(cantidadArticulo, out validCantidad));



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

        private void btnRemoverArticulo_Click(object sender, EventArgs e)
        {
            int IdArticuloRemover = 0;
            if (aRTICULOSDataGridView.SelectedRows.Count <= 0)
            {
                this.MensajeAdvertencia("No hay artículo seleccionado para remover, favor de verificar !", "Error al Remover Artículo");
                return;
            }

            if (!int.TryParse(aRTICULOSDataGridView.SelectedRows[0].Cells[0].Value.ToString(), out IdArticuloRemover))
            {
                this.MensajeAdvertencia("El artículo seleccionado no es válido, intentar nuevamente!", "Error al Remover Artículo");
                return;
            }
            var articulo = db.ARTICULOS.Find(IdArticuloRemover);

            DialogResult result = this.Mensaje(text: "¿Seguro que desea remover el artículo [" + articulo.descripcion + "] de la factura ?", buttons: MessageBoxButtons.YesNo, icon: MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (RemoverArticulo(IdArticuloRemover))
                {

                    this.MensajeInformacion("Artículo [" + articulo.descripcion + "] removido de la factura.", "Artículo Removido");
                }
                else
                {
                    this.MensajeError("Ocurrió algún error al remvoer artículo de factura, favor de verificar !", "Error al Remover Artículo");
                }
            }

        }

        #endregion


        private void RealizarCalculos()
        {
            float totalBruto = 0;// float.Parse(string.IsNullOrEmpty(txtTotalBruto.Text) ? "0" : txtTotalBruto.Text);
            float PorcentajeDescuento = float.Parse(string.IsNullOrEmpty(txtPorcentajeDescuento.Text) ? "0" : txtPorcentajeDescuento.Text);
            float PorcentajeITBIS = float.Parse(string.IsNullOrEmpty(txtPorcentajeITBIS.Text) ? "0" : txtPorcentajeITBIS.Text);

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
            totalBruto = float.Parse(dsArticulosFacturados.Sum(a => a.importe).ToString());
            txtTotalBruto.Text = totalBruto.ToString("c");
            #endregion

            #region Descuento
            txtDescuento.Text = (totalBruto * (PorcentajeDescuento / 100)).ToString("c");
            #endregion

            #region ITBIS
            txtITBIS.Text = (totalBruto * (PorcentajeITBIS / 100)).ToString("c");
            #endregion

            #region Total
            txtTotalNeto.Text = (totalBruto - (totalBruto * (PorcentajeDescuento / 100)) + (totalBruto * (PorcentajeITBIS / 100))).ToString("c"); ;
            #endregion
        }

        private void aRTICULOSDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            RealizarCalculos();
        }

        private void aRTICULOSDataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            RealizarCalculos();
        }

        private void Recalcular_TextChanged(object sender, EventArgs e)
        {
            int PorcentajeDescuento = 0;
            txtPorcentajeDescuento.Text = string.IsNullOrEmpty(txtPorcentajeDescuento.Text) ? "0" : txtPorcentajeDescuento.Text;
            if (int.TryParse(txtPorcentajeDescuento.Text, out PorcentajeDescuento))
            {
                if (PorcentajeDescuento >= 0 || PorcentajeDescuento <= 100)
                {
                    RealizarCalculos();
                }
                else
                {
                    this.MensajeAdvertencia("El porcentaje de descuento debe estar entre 0-100", "Error Porcentaje Descuento");
                }
            }
            else
            {
                this.MensajeAdvertencia("El porcentaje de descuento insertado no es válido, favor de verificar !");
            }

        }

        private bool ValidatarDatosFactura()
        {
            string message = "";
            bool valido = true;
            if (User.UsuarioLogeado == null || String.IsNullOrEmpty(User.UsuarioLogeado.IdUsuario.ToString())) //User.Identity.IsAuthenticated
            {
                valido = false;
                message = "Debe Identificarse como un Vendedor valido, favor de verificar!!";
            }
            else if (idCondicionPagoComboBox.SelectedIndex == -1)
            {
                valido = false;
                message = "Debe especificar La Condición de Pago, favor de verificar!!";
                idCondicionPagoComboBox.Focus();
            }
            else if (string.IsNullOrEmpty(comentarioTextBox.Text))
            {
                valido = false;
                message = "El campo Comentario es requerido, favor de verificar!!";
            }
            else if (String.IsNullOrEmpty(idTextBoxCliente.Text))
            {
                valido = false;
                message = "Debe especificar un Cliente válido, favor de verificar!!";
            }
            else if (ArticulosFacturados.Count <= 0)
            {
                valido = false;
                message = "No hay artículos facturados, favor de verificar!!";
            }

            if (!valido) this.MensajeAdvertencia(message);


            return valido;
        }

        private void btnGuardarFactura_Click(object sender, EventArgs e)
        {
            if (ValidatarDatosFactura())
            {
                try
                {
                    using (TransactionScope trans = new TransactionScope())
                    {
                        FACTURAS factura = new FACTURAS();
                        DETALLE_FACTURA detalleFactura = new DETALLE_FACTURA();

                        factura.comentario = comentarioTextBox.Text;
                        factura.fechaRegistro = DateTime.Now;
                        factura.idCondicionPago = int.Parse(idCondicionPagoComboBox.SelectedValue.ToString());
                        factura.idVendedor = User.UsuarioLogeado.IdUsuario;
                        factura.idCliente = int.Parse(idTextBoxCliente.Text);
                        factura.PorcentajeDescuento = int.Parse(string.IsNullOrEmpty(txtPorcentajeDescuento.Text) ? "0" : txtPorcentajeDescuento.Text);
                        factura.ITBIS = int.Parse(string.IsNullOrEmpty(txtPorcentajeITBIS.Text) ? "0" : txtPorcentajeITBIS.Text);
                        db.FACTURAS.Add(factura);

                        foreach (var articuloFacturado in ArticulosFacturados)
                        {
                            detalleFactura = new DETALLE_FACTURA();
                            detalleFactura.idArticulo = articuloFacturado.Key;
                            detalleFactura.idFactura = factura.id;
                            detalleFactura.precioUnitario = db.ARTICULOS.Find(articuloFacturado.Key).precioUnitario;
                            detalleFactura.cantidad = articuloFacturado.Value;
                            db.DETALLE_FACTURA.Add(detalleFactura);
                        }

                        db.SaveChanges();
                        LimpiarCamposFactura();
                        trans.Complete();
                     
                       this.MensajeInformacion(string.Format("Factura registrada. No. {0}", factura.id));
                        


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

        private void LimpiarCamposFactura()
        {
            ArticulosFacturados.Clear();
            LimpiarControlesClientes();
            txtPorcentajeDescuento.Text = "0";
           
            txtVendedor.Text = User.UsuarioLogeado.NombreCompleto;
            idCondicionPagoComboBox.SelectedIndex = -1;
            fechaRegistroDateTimePicker.ResetText();
            comentarioTextBox.Clear();
            RealizarCalculos();
            CargarGridArticulosFacturados();
          
            
          

        }
        /*
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

}
         
         
         
         
*/
       
    }
}
