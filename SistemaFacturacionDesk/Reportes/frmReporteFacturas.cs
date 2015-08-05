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
    public partial class frmReporteFacturas : Form
    {
        private EntitiesFACTURACION db = new EntitiesFACTURACION();

        public int? IdCliente { get; set; }
        public DateTime? F_Desde { get; set; }
        public DateTime? F_Hasta { get; set; }


        public frmReporteFacturas()
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
            IdCliente = IdCliente ?? 0;

            ReportParameterCollection ReportParameters = new ReportParameterCollection();
            ReportParameters.Add(new ReportParameter("F_Desde", F_Desde.HasValue ? F_Desde.Value.ToShortDateString() : ""));
            ReportParameters.Add(new ReportParameter("F_Hasta", F_Hasta.HasValue ? F_Hasta.Value.ToShortDateString() : ""));

            ReportDataSource source = new ReportDataSource();
            source.Name = "FacturaDataset";
            source.Value = CargarFacturas(IdCliente, F_Desde, F_Hasta).Value;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.LocalReport.ReportEmbeddedResource = "rptReporteFacturas.rdlc";
            reportViewer1.LocalReport.ReportPath = @"Reportes/rptReporteFacturas.rdlc";
            reportViewer1.LocalReport.SetParameters(ReportParameters);
            reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }

        private ReportDataSource CargarFacturas(int? IdCliente, DateTime? F_Desde, DateTime? F_Hasta)
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
                                f.fechaRegistroFactura,
                                f.importe,
                                f.descuentoFactura,
                                f.itbisFactura
                            }
                         ).Distinct().ToList();

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "FacturasDataSource";
            rds.Value = facturas.ToList();

            return rds;

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
