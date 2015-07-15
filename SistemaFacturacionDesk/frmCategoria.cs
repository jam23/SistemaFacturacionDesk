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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmArticulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Visible = true;
            this.Dispose();
        }
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            estadoComboBox.DataSource = Utilidades.Estados;
            // TODO: This line of code loads data into the 'fACTURACIONDataSet.CATEGORIA' table. You can move, or remove it, as needed.
            this.cATEGORIATableAdapter.Fill(this.fACTURACIONDataSet.CATEGORIA);
        }

        private void ValidarInsercionDatos()
        {
            descripcionTextBox.ValidarContenido(TipoDatos.Alfanumerico);
        }

        private bool ValidarDatosCampos()
        {
            bool resultado = true;
            string NombreCampo = "";
            if (string.IsNullOrEmpty(descripcionTextBox.Text))
            {
                resultado = false;
                NombreCampo = "Descripción";
                descripcionTextBox.Focus();
            }
            else if (estadoComboBox.SelectedIndex == -1)
            {
                resultado = false;
                NombreCampo = "Estado";
                estadoComboBox.Focus();
            }

            if (!resultado) this.MensajeAdvertencia("El campo " + NombreCampo + " no puede estar en blanco.", "Datos en Blanco");

            return resultado;
        }
        private void cATEGORIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string mensaje = Utilidades.ObtenerMensajeInsertarModificar(this.cATEGORIABindingSource.Current);

            if (ValidarDatosCampos() && this.Validate())
            {
                this.cATEGORIABindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fACTURACIONDataSet);

                if (!string.IsNullOrEmpty(mensaje))
                {
                    this.MensajeInformacion(mensaje);
                }
            }
        }

        private void fillByDescripcion(object sender, EventArgs e)
        {
            try
            {
                this.cATEGORIATableAdapter.FillByDescripcion(this.fACTURACIONDataSet.CATEGORIA, txtDescripcion.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            fillByDescripcion(sender, e);
        }

        private void frmCategoria_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Visible = true;
            this.Dispose();
        }
    }
}
