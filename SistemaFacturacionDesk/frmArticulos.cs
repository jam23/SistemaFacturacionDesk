using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
     
        private void frmArticulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Visible = true;
            this.Dispose();
        }

        private void ValidarInsercionDatos()
        {

            stockTextBox.ValidarContenido(TipoDatos.Numerico);
            descripcionTextBox.ValidarContenido(TipoDatos.Alfanumerico);
            costoUnitarioTextBox.ValidarContenido(TipoDatos.Numerico);
            precioUnitarioTextBox.ValidarContenido(TipoDatos.Numerico);
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
         
            //Validar que no se permitan ciertas teclas presionadas.
            ValidarInsercionDatos();

            estadoComboBox.DataSource = Utilidades.Estados;
            // TODO: This line of code loads data into the 'fACTURACIONDataSet.CATEGORIA' table. You can move, or remove it, as needed.
            this.cATEGORIATableAdapter.Fill(this.fACTURACIONDataSet.CATEGORIA);
            // TODO: This line of code loads data into the 'fACTURACIONDataSet.ARTICULOS' table. You can move, or remove it, as needed.
            this.aRTICULOSTableAdapter.Fill(this.fACTURACIONDataSet.ARTICULOS);
        }

        private void aRTICULOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string mensaje = Utilidades.ObtenerMensajeInsertarModificar(this.aRTICULOSBindingSource.Current,"Articulo Insertado.","Articulo Modificado.");
            
            if (ValidarDatosCampos() && this.Validate())
            {                
                try
                {
                    this.aRTICULOSBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.fACTURACIONDataSet);
                }
                catch (NoNullAllowedException ex)
                {
                    this.MensajeAdvertencia("Existen Campos con valores en blanco, favor de verificar. ");
                    return;
                }             

                if (!string.IsNullOrEmpty(mensaje))
                {
                    this.MensajeInformacion(mensaje);
                }

            }
        }

        private void fillByDescripcion_Click(object sender, EventArgs e)
        {
            try
            {
                this.aRTICULOSTableAdapter.FillByDescripcion(this.fACTURACIONDataSet.ARTICULOS, txtDescripcion.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            fillByDescripcion_Click(sender, e);
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
            else if (idCategoriaComboBox.SelectedIndex == -1)
            {
                resultado = false;
                NombreCampo = "Categoría";
                idCategoriaComboBox.Focus();
            }
            else if (string.IsNullOrEmpty(costoUnitarioTextBox.Text))
            {
                resultado = false;
                NombreCampo = "Costo Unitario";
                costoUnitarioTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(precioUnitarioTextBox.Text))
            {
                resultado = false;
                NombreCampo = "Precio Unitario";
                precioUnitarioTextBox.Focus();
            }
            else if (string.IsNullOrEmpty(stockTextBox.Text))
            {
                resultado = false;
                NombreCampo = "Stock";
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




    }
}
