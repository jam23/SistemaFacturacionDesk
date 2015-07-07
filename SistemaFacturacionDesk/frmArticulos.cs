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
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }
        EntitiesFACTURACION db = new EntitiesFACTURACION();
        private void frmArticulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Visible = true;
            this.Dispose();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            costoUnitarioTextBox.ValidarContenido(Validaciones.Alfanumerico);
            estadoComboBox.DataSource = Utilidades.Estado;
            // TODO: This line of code loads data into the 'fACTURACIONDataSet.CATEGORIA' table. You can move, or remove it, as needed.
            this.cATEGORIATableAdapter.Fill(this.fACTURACIONDataSet.CATEGORIA);
            // TODO: This line of code loads data into the 'fACTURACIONDataSet.ARTICULOS' table. You can move, or remove it, as needed.
            this.aRTICULOSTableAdapter.Fill(this.fACTURACIONDataSet.ARTICULOS);
            
   
            
          

        }

        private void aRTICULOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aRTICULOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.fACTURACIONDataSet);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     



    }
}
