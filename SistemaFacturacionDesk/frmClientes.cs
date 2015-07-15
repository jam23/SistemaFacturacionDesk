using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacionDesk
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmArticulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Visible = true;
            this.Dispose();
        }

        private void cLIENTESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string mensaje = Utilidades.ObtenerMensajeInsertarModificar(this.cLIENTESBindingSource.Current);

            if (ValidarDatosCampos() && this.Validate())
            {
                this.cLIENTESBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fACTURACIONDataSet);

                if (!string.IsNullOrEmpty(mensaje))
                {
                    this.MensajeInformacion(mensaje);
                }
            }

        }

        private void ValidarInsercionDatos()
        {
            nombreComercialTextBox.ValidarContenido(TipoDatos.Alfanumerico);
            razonSocialTextBox.ValidarContenido(TipoDatos.Alfanumerico);
            rNC_CEDTextBox.ValidarContenido(TipoDatos.Numerico);
            cuentaContableTextBox.ValidarContenido(TipoDatos.Numerico);
            telefonoTextBox.ValidarContenido(TipoDatos.Numerico);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ValidarInsercionDatos();
            estadoComboBox.DataSource = Utilidades.Estados;
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
        }

        private bool ValidarDatosCampos()
        {
            bool resultado = true;
            string NombreCampo = "";
            if (string.IsNullOrEmpty(nombreComercialTextBox.Text))
            {
                resultado = false;
                NombreCampo = "Nombre Comercial";
                nombreComercialTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(razonSocialTextBox.Text))
            {
                resultado = false;
                NombreCampo = "Razón Social";
                razonSocialTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(rNC_CEDTextBox.Text))
            {
                resultado = false;
                NombreCampo = "RNC/CED";
                rNC_CEDTextBox.Focus();
            }
            else if (rNC_CEDTextBox.Text.Trim().Length == 11 && !Utilidades.ValidaCedula(rNC_CEDTextBox.Text))
            {
                this.MensajeAdvertencia("La Cédula insertada no es válida, favor de verificar");
                resultado = false;
                return resultado;
            }
            else if (string.IsNullOrEmpty(cuentaContableTextBox.Text))
            {
                resultado = false;
                NombreCampo = "Cuenta Contable";
                cuentaContableTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(telefonoTextBox.Text))
            {
                resultado = false;
                NombreCampo = "Teléfono";
                telefonoTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                resultado = false;
                NombreCampo = "Email";
                emailTextBox.Focus();
            }
            else if (!Regex.IsMatch(emailTextBox.Text, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                resultado = false;
                emailTextBox.Focus();
                this.MensajeAdvertencia("Debe insertar un Email que sea correcto, favor de verificar!");
                return resultado;
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

        private void frmClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Visible = true;
            this.Dispose();
        }



    }
}
