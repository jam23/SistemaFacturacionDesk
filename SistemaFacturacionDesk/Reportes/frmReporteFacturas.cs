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

namespace SistemaFacturacionDesk.Reportes
{
    public partial class frmReporteFacturas : Form
    {
        EntitiesFACTURACION db = new EntitiesFACTURACION();
        frmBusquedaCliente formBusquedaCliente = new frmBusquedaCliente();
        public frmReporteFacturas()
        {
            InitializeComponent();
        }

        private void frmReporteFacturas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fACTURACIONDataSet.FACTURAS' table. You can move, or remove it, as needed.
            this.fACTURASTableAdapter.Fill(this.fACTURACIONDataSet.FACTURAS);


        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            formBusquedaCliente.Visible = true;
            formBusquedaCliente.Owner = this;
        }

        public void SetearCliente(int IdCliente)
        {
            var cliente = db.CLIENTES.Find(IdCliente);
            if (cliente != null)
            {
                txtIdCliente.Text = cliente.id.ToString();
                txtNombreCliente.Text = cliente.nombreComercial;
            }
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtIdCliente.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            RangoFechaValido();
        }

        private bool RangoFechaValido()
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                this.MensajeAdvertencia("La fecha [Desde] no puede ser mayor que la fecha [Hasta].", "Error en Rango de Fecha");
                return false;
            }

            return true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                this.fACTURASTableAdapter.ObtenerFacturasIdClienteRangoFecha(this.fACTURACIONDataSet.FACTURAS, new System.Nullable<int>(((int)(System.Convert.ChangeType(txtIdCliente.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtpDesde.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtpHasta.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void CargarDatos()
        {




            /*
            SELECT
    F.id AS idFactura,
    F.idVendedor,
    V.nombres + ' ' + V.apellido1 + ' ' + V.apellido2 AS nombreVendedor,
    F.idCliente,
    CL.razonSocial,
    CL.nombreComercial,
    CL.RNC_CED,
    CL.cuentaContable,
    CL.telefono,
    CL.email,
    F.comentario AS comentarioFactura,
    F.fechaRegistro AS fechaRegistroFactura,
    F.ITBIS AS itbisFactura,
    F.PorcentajeDescuento AS descuentoFactura,
    CP.descripcion as condicionPago,
    CP.cantidadDias,
    A.id AS idArticulo,
    A.descripcion AS descripcionArticulo,
    A.costoUnitario as costoUnitarioArticulo,
    A.precioUnitario as precioUnitarioArticulo,
    DF.cantidad as cantidadFacturado,
    DF.precioUnitario AS precioUnitarioFacturado,
    CA.descripcion AS  descripcionCategoriaArticulo,
    CA.id AS idCategoria
FROM FACTURAS AS F
LEFT JOIN ARTICULOS AS A
    ON F.id = A.id
LEFT JOIN CATEGORIA AS CA
    ON A.idCategoria = CA.id
LEFT JOIN CLIENTES AS CL
    ON F.idCliente = CL.id
LEFT JOIN CONDICIONESPAGO AS CP
    ON F.idCondicionPago = CP.id
LEFT JOIN DETALLE_FACTURA AS DF
    ON F.id = DF.idFactura AND A.id = DF.idArticulo
LEFT JOIN VENDEDORES AS V
    ON F.idVendedor = V.id
    WHERE
    CL.id = @idCliente
    AND
    F.fechaRegistro BETWEEN @F_Desde AND @F_Hasta

        */

        }

        private void obtenerFacturasIdClienteRangoFechaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.fACTURASTableAdapter.ObtenerFacturasIdClienteRangoFecha(this.fACTURACIONDataSet.FACTURAS, new System.Nullable<int>(((int)(System.Convert.ChangeType(idClienteToolStripTextBox.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(f_DesdeToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(f_HastaToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void obtenerFacturasIdClienteRangoFechaToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.fACTURASTableAdapter.ObtenerFacturasIdClienteRangoFecha(this.fACTURACIONDataSet.FACTURAS, new System.Nullable<int>(((int)(System.Convert.ChangeType(idClienteToolStripTextBox.Text, typeof(int))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(f_DesdeToolStripTextBox.Text, typeof(System.DateTime))))), new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(f_HastaToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

   





    }
}
