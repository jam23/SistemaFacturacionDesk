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
    public partial class frmConsultaReporteFacturas : Form
    {
        private EntitiesFACTURACION db = new EntitiesFACTURACION();
        private frmBusquedaCliente formBusquedaCliente = new frmBusquedaCliente();
        private frmReporteDetalleFactura reporteFactura = new frmReporteDetalleFactura();
        private frmReporteFacturas rptFactura = new frmReporteFacturas();
        public frmConsultaReporteFacturas()
        {
            InitializeComponent();
        }

        private void frmReporteFacturas_Load(object sender, EventArgs e)
        {
            fACTURASDataGridView.AutoGenerateColumns = false;
            LimpiarDateTimePicker(new DateTimePicker[] { dtpDesde, dtpHasta });
            CargarFacturas(0, null, null);

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
            dtpHasta.Format = DateTimePickerFormat.Short;
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

        private void LimpiarDateTimePicker(DateTimePicker[] Pickers)
        {
            foreach (DateTimePicker item in Pickers)
            {
                item.ResetText();
                item.Format = DateTimePickerFormat.Custom;
                item.CustomFormat = " ";
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int? IdCliente = String.IsNullOrEmpty(txtIdCliente.Text) ? 0 : int.Parse(txtIdCliente.Text);
            DateTime? F_Desde = string.IsNullOrEmpty(dtpDesde.Text.Trim()) ? null : new System.Nullable<System.DateTime>(DateTime.Parse(dtpDesde.Text));// new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtpDesde.Text, typeof(System.DateTime)))));
            DateTime? F_Hasta = string.IsNullOrEmpty(dtpHasta.Text.Trim()) ? null : new System.Nullable<System.DateTime>(DateTime.Parse(dtpHasta.Text));//null : new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtpHasta.Text, typeof(System.DateTime)))));

            if (F_Desde == null && F_Hasta != null)
            {
                this.MensajeAdvertencia("Debe Especificar la fecha [Desde]");
                return;
            }
            else if (F_Desde != null && F_Hasta == null)
            {
                this.MensajeAdvertencia("Debe Especificar la fecha [Hasta]");
                return;
            }

            if (!RangoFechaValido()) return;

            this.CargarFacturas(IdCliente, F_Desde, F_Hasta);
        }

        public void CargarFacturas(int? IdCliente, DateTime? F_Desde, DateTime? F_Hasta)
        {
            var facturas = (from f
                            in db.ObtenerFacturasIdClienteRangoFecha(null, IdCliente, F_Desde, F_Hasta)
                            select new
                            {
                                f.idFactura,
                                f.idVendedor,
                                f.nombreVendedor,
                                f.idCliente,
                                f.nombreComercial,
                                f.RNC_CED,
                                f.condicionPago,
                                f.fechaRegistroFactura
                               
                            }
                          ).Distinct().ToList();
            fACTURASDataGridView.DataSource = facturas;
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {
            dtpDesde.Format = DateTimePickerFormat.Short;
        }

        private void btnLimpiarFechas_Click(object sender, EventArgs e)
        {
            LimpiarDateTimePicker(new DateTimePicker[] { dtpDesde, dtpHasta });
        }

        private void fACTURASDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                reporteFactura.IdFactura = int.Parse(fACTURASDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                reporteFactura.Visible = true;
            }
            else
            {
                this.MensajeAdvertencia("Error al seleccionar factura, favor intentar nuevamente.");
            }
        }

        private void frmConsultaReporteFacturas_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Visible = true;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rptFactura.IdCliente = String.IsNullOrEmpty(txtIdCliente.Text) ? 0 : int.Parse(txtIdCliente.Text);
            rptFactura.F_Desde = string.IsNullOrEmpty(dtpDesde.Text.Trim()) ? null : new System.Nullable<System.DateTime>(DateTime.Parse(dtpDesde.Text));// new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtpDesde.Text, typeof(System.DateTime)))));
            rptFactura.F_Hasta = string.IsNullOrEmpty(dtpHasta.Text.Trim()) ? null : new System.Nullable<System.DateTime>(DateTime.Parse(dtpHasta.Text));//null : new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dtpHasta.Text, typeof(System.DateTime)))));
                      
            
            rptFactura.Visible = true;
        }
    }
}
