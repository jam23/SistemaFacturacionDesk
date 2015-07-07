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
    public partial class frmCondicionesPago : Form
    {
        public frmCondicionesPago()
        {
            InitializeComponent();
        }

        private void cONDICIONESPAGOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cONDICIONESPAGOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fACTURACIONDataSet);

        }

        private void frmCondicionesPago_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fACTURACIONDataSet.CONDICIONESPAGO' table. You can move, or remove it, as needed.
            this.cONDICIONESPAGOTableAdapter.Fill(this.fACTURACIONDataSet.CONDICIONESPAGO);

        }
    }
}
