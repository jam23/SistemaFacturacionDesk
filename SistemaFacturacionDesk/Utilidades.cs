using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacionDesk
{
    static class Utilidades
    {
        #region Mensajes
        public static void Mensaje(this Form form, string text = "", string caption = "", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None)
        {
            MessageBox.Show(form, text, caption, buttons, icon);
        }

        public static void MensajeAdvertencia(this Form form, string text, string caption= "")
        {
            Mensaje(form, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void MensajeError(this Form form, string text, string caption = "")
        {
            Mensaje(form, text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Cuenta

       
        #endregion


    }
}
