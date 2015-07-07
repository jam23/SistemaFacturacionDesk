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
    public enum Validaciones
    {
        Alfanumerico,
        Letras,
        Numerico,
        Email,
        Cedula
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

        public static void ValidarContenido(this TextBox textBox, Validaciones TipoValidacion)
        {
            switch (TipoValidacion)
            {
                case Validaciones.Alfanumerico:
                    break;
                case Validaciones.Numerico:
                    break;
                case Validaciones.Email:
                    break;
                case Validaciones.Cedula:
                    break;
                case Validaciones.Letras:
                    textBox.KeyPress += textBox_KeyPress;
                    break;
                default:
                    break;
            }

        }

        private static void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z')))
            {
                e.Handled = true;
            }
        }

    }
}
