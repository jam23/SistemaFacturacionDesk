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
    public partial class frmVendedores : Form
    {
        public frmVendedores()
        {
            InitializeComponent();
        }

        private void frmVendedores_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Visible = true;
            this.Dispose();
        }

        
        private void vENDEDORESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string mensaje = Utilidades.ObtenerMensajeInsertarModificar(this.vENDEDORESBindingSource.Current);

            if (ValidarDatosCampos())
            {
                this.vENDEDORESBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fACTURACIONDataSet);

                if (!string.IsNullOrEmpty(mensaje))
                {
                    this.MensajeInformacion(mensaje);
                }

            }
        }

        private bool ValidarDatosCampos()
        {
            bool resultado = true;
            string NombreCampo = "";

            if (!this.Validate())
            {
                resultado = false;
            }


            if (string.IsNullOrEmpty(nombresTextBox.Text))
            {
                resultado = false;
                NombreCampo = "Nombre";
                nombreUsuarioTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(apellido1TextBox.Text))
            {
                resultado = false;
                NombreCampo = "Apellido 1";
                apellido1TextBox.Focus();
            }
            else if (string.IsNullOrEmpty(apellido2TextBox.Text))
            {
                resultado = false;
                NombreCampo = "Apellido 2";
                apellido2TextBox.Focus();
            }
            else if (string.IsNullOrEmpty(porcientoComisionTextBox.Text))
            {
                resultado = false;
                NombreCampo = "(%) Comisión";
                porcientoComisionTextBox.Focus();
            }
            else if (int.Parse(porcientoComisionTextBox.Text) < 0 || int.Parse(porcientoComisionTextBox.Text) > 100)
            {
                resultado = false;
                this.MensajeAdvertencia("Rango del porcentaje de Comisión 0-100, favor de verificar.");
                porcientoComisionTextBox.Focus();
                return resultado;
            }
            else if (estadoComboBox.SelectedIndex == -1)
            {
                resultado = false;
                NombreCampo = "Estado";
                estadoComboBox.Focus();
            }
            else if (string.IsNullOrEmpty(nombreUsuarioTextBox.Text))
            {
                resultado = false;
                NombreCampo = "Nombre de Usuario";
                nombreUsuarioTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(contrasenaTextBox.Text))
            {
                resultado = false;
                NombreCampo = "Contraseña";
                contrasenaTextBox.Focus();
            }

            if (!resultado)
            {
                if (!string.IsNullOrEmpty(NombreCampo))
                {
                    this.MensajeAdvertencia("El campo " + NombreCampo + " no puede estar en blanco.", "Datos en Blanco");
                }
                else
                {
                    this.MensajeAdvertencia("Ocurrió algún error, favor de verificar.");
                }
            }


            return resultado;
        }

        private void ValidarInsertcionDatos()
        {
            nombresTextBox.ValidarContenido(TipoDatos.Alfanumerico);
            apellido1TextBox.ValidarContenido(TipoDatos.Alfanumerico);
            apellido2TextBox.ValidarContenido(TipoDatos.Alfanumerico);
            porcientoComisionTextBox.ValidarContenido(TipoDatos.Numerico);
            nombreUsuarioTextBox.ValidarContenido(TipoDatos.Alfanumerico);

        }

        private void frmVendedores_Load(object sender, EventArgs e)
        {
            ValidarInsertcionDatos();
            estadoComboBox.DataSource = Utilidades.Estados;
            // TODO: This line of code loads data into the 'fACTURACIONDataSet.VENDEDORES' table. You can move, or remove it, as needed.
            this.vENDEDORESTableAdapter.Fill(this.fACTURACIONDataSet.VENDEDORES);

        }

        private void fillByNombresApellidosUsuario(object sender, EventArgs e)
        {
            try
            {
                this.vENDEDORESTableAdapter.FillByNombresApellidosUsuario(this.fACTURACIONDataSet.VENDEDORES, txtFilterValue.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtFilterValue.Clear();
            fillByNombresApellidosUsuario(sender, e);
        }
    }
}
