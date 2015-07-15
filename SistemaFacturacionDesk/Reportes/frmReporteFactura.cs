using Microsoft.Reporting.WinForms;
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
    public partial class frmReporteFactura : Form
    {
        private EntitiesFACTURACION db = new EntitiesFACTURACION();
        public int IdFactura { get; set; }
        public frmReporteFactura()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void frmReporteFactura_Load(object sender, EventArgs e)
        {
           
            CargarReporte();
        }

        private void CargarReporte()
        {
            ReportDataSource source = new ReportDataSource();
            source.Name = "FacturaDataset";
            source.Value = db.ObtenerFacturasIdClienteRangoFecha(IdFactura, null, null, null);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.LocalReport.ReportEmbeddedResource = "rptReporteFacturas.rdlc";
            reportViewer1.LocalReport.ReportPath = @"Reportes/rptReporteFacturas.rdlc";
            reportViewer1.LocalReport.Refresh();
            
            this.reportViewer1.RefreshReport();
        }

        private void frmReporteFactura_VisibleChanged(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Visible = false;            
        }

        private void frmReporteFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utilidades.PrevenirUsuarioCerrarVentana(e);
            this.Visible = false;
        }
    }
}
