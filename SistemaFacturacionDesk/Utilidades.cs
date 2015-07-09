using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacionDesk
{
    public enum TipoDatos
    {
        Alfanumerico,
        Numerico
        //,
        //Letras,
        //Email,
        //Cedula
    }
    public static class Utilidades
    {
        #region Mensajes
        public static void Mensaje(this Form form, string text = "", string caption = "", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None)
        {
            MessageBox.Show(form, text, caption, buttons, icon);
        }

        public static void MensajeAdvertencia(this Form form, string text, string caption = "")
        {
            Mensaje(form, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MensajeError(this Form form, string text, string caption = "")
        {
            Mensaje(form, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MensajeInformacion(this Form form, string text, string caption = "")
        {
            Mensaje(form, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        #endregion


        public static List<KeyValuePair<string, string>> Estado = new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("A", "Activo"), new KeyValuePair<string, string>("I", "Inactivo") };

        #region Validaciones

        public static void ValidarContenido(this TextBox textBox, TipoDatos TipoValidacion)
        {
            switch (TipoValidacion)
            {
                case TipoDatos.Alfanumerico:
                    textBox.KeyPress += validacion_Alfanumerico;
                    break;
                case TipoDatos.Numerico:
                    textBox.KeyPress += validacion_numerico;
                    break;
                default:
                    break;
            }

        }

        private static void validacion_numerico(object sender, KeyPressEventArgs e)
        {
            // if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')))
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == char.Parse(".")) //Espacio: || char.IsSeparator(e.KeyChar)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true; //LOS DEMAS QUEDAN BLOQUEADOS
            }


        }

        private static void validacion_Alfanumerico(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) || !char.IsControl(e.KeyChar) || !char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}

            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar))
            {
                e.Handled = false; //QUE NO SE BLOQUEE LAS LETRAS
            }
            else
            {
                e.Handled = true; //LOS DEMAS QUEDAN BLOQUEADOS
            }

        }

        #endregion


        public static void PrevenirUsuarioCerrarVentana(FormClosingEventArgs e)
        {
            //Prevenir que el usuario cierre el formulario presionando la "X" de la ventana.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
