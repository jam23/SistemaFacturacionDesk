using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacionDesk.Busquedas
{
    public partial class frmBusquedaArticulo : Form
    {
        public frmBusquedaArticulo()
        {
            InitializeComponent();
        }

        private void frmBusquedaArticulo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fACTURACIONDataSet.CATEGORIA' table. You can move, or remove it, as needed.
            this.cATEGORIATableAdapter.Fill(this.fACTURACIONDataSet.CATEGORIA);
            // TODO: This line of code loads data into the 'fACTURACIONDataSet.ARTICULOS' table. You can move, or remove it, as needed.
           this.aRTICULOSTableAdapter.Fill(this.fACTURACIONDataSet.ARTICULOS);
            //this.aRTICULOSTableAdapter.FillByCategoriaDescripcion(this.fACTURACIONDataSet.ARTICULOS,0, "");
        }

        private void fillByDescripcion(object sender, EventArgs e)
        {
            try
            {
                this.aRTICULOSTableAdapter.FillByDescripcion(this.fACTURACIONDataSet.ARTICULOS, txtFilterValue.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            fillByDescripcion(sender, e);
        }

        private void cLIENTESDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmFacturacion form = (frmFacturacion)this.Owner;
            form.SetearArticulo(int.Parse(cLIENTESDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
            this.Visible = false;
        }
    }
}
