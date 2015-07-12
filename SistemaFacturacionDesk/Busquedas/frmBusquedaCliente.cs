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
    public partial class frmBusquedaCliente : Form
    {
        public frmBusquedaCliente()
        {
            InitializeComponent();
        }

        private void cLIENTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLIENTESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fACTURACIONDataSet);

        }

        private void frmBusquedaCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fACTURACIONDataSet.CLIENTES' table. You can move, or remove it, as needed.
            this.cLIENTESTableAdapter.Fill(this.fACTURACIONDataSet.CLIENTES);

        }

        private void fillByNombreRazonCEDRNC(object sender, EventArgs e)
        {
            try
            {
                this.cLIENTESTableAdapter.FillByNombreRazonCEDRNC(this.fACTURACIONDataSet.CLIENTES, txtFilterValue.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtFilterValue.Clear();
            fillByNombreRazonCEDRNC(sender, e);
            this.Visible = false;
            this.Owner.Focus();

        }

        private void cLIENTESDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmFacturacion form = (frmFacturacion)this.Owner;
            if (e.RowIndex >= 0)
            {
                form.SetearCliente(int.Parse(cLIENTESDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString()));
            }
            else
            {
                this.MensajeAdvertencia("Error al seleccionar cliente, favor intentar nuevamente.");
            }

            this.Visible = false;
        }

        private void frmBusquedaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utilidades.PrevenirUsuarioCerrarVentana(e);
        }
    }
}
