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
        public static DialogResult Mensaje(this Form form, string text = "", string caption = "", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None)
        {
            return MessageBox.Show(form, text, caption, buttons, icon);
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


        public static List<KeyValuePair<string, string>> Estados = new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("A", "Activo"), new KeyValuePair<string, string>("I", "Inactivo") };
        public const string ContrasenaDefecto = "contrasena01";
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

        public static bool ValidaCedula(string cedula)
        {
            int verificador = 0;
            int digito = 0;
            int digitoVerificador = 0;
            int digitoImpar = 0;
            int sumaPar = 0;
            int sumaImpar = 0;

            int longitud = Convert.ToInt32(cedula.Length);
            try
            {
                if (longitud == 11)
                {
                    digitoVerificador = Convert.ToInt32(cedula.Substring(10, 1));                    
                    for (int i = 9; i >= 0; i--)                    {
                    
                        digito = Convert.ToInt32(cedula.Substring(i, 1));
                        if ((i % 2) != 0)
                        {
                            digitoImpar = digito * 2;                    
                            if (digitoImpar >= 10)
                            {
                                digitoImpar = digitoImpar - 9;
                            }
                            sumaImpar = sumaImpar + digitoImpar;
                        }                    
                        else
                        {
                            sumaPar = sumaPar + digito;
                        }
                    }
                    
                    verificador = 10 - ((sumaPar + sumaImpar) % 10);                    
                    if (((verificador == 10) && (digitoVerificador == 0)) || (verificador == digitoVerificador))
                    {
                        return true;
                    }
                }               
            }
            catch
            {
                Console.WriteLine("No se pudo validar la cédula");
            }
            return false;
        }

        public static string ObtenerMensajeInsertarModificar(object FilaActual, string MensajeInsertar = "Insertado.", string MensajeModificarEliminar = "Modificado.")
        {
            if (FilaActual == null) return string.Empty;

            DataRowView currentRow = (DataRowView)(FilaActual);
            string mensaje = string.Empty;

            if (currentRow.IsNew)
            {
                mensaje = MensajeInsertar;
            }
            else if (currentRow.IsEdit)
            {
                mensaje = MensajeModificarEliminar;
            }

            return mensaje;
        }



    }
}
