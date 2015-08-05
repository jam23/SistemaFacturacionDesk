using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacionDesk.Cuenta
{
    public partial class frmCambiarContrasena : Form
    {

        private string ContrasenaActual
        {
            get
            {
                using (EntitiesFACTURACION db = new EntitiesFACTURACION())
                {
                    return db.VENDEDORES.Find(User.UsuarioLogeado.IdUsuario).contrasena;
                }
            }
        }

        public frmCambiarContrasena()
        {
            InitializeComponent();

        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            if (ValidarNuevaContrasena())
            {
                using (EntitiesFACTURACION db = new EntitiesFACTURACION())
                {
                    db.VENDEDORES.Find(User.UsuarioLogeado.IdUsuario).contrasena = txtNuevaContrasena.Text;
                    db.SaveChanges();
                    this.MensajeInformacion("Contraseña Cambiada, favor de verificar");
                    User.CerrarSesion();
                    frmIniciarSesion frmIniciarSesion = new frmIniciarSesion();
                    frmIniciarSesion.Visible = true;
                    this.Dispose();
                }

            }

        }


        private bool ValidarNuevaContrasena()
        {
            if (string.IsNullOrEmpty(txtContrasenaActual.Text))
            {
                this.MensajeAdvertencia("Debe especificar la contraseña actual.", "Contraseña Actual");
                return false;
            }

          
                if (ContrasenaActual != txtContrasenaActual.Text)
                {
                    this.MensajeAdvertencia("La contraseña actual no es correcta, favor de verificar");
                    return false;
                }
            

            if (string.IsNullOrEmpty(txtNuevaContrasena.Text))
            {
                this.MensajeAdvertencia("Debe especificar la contraseña nueva.", "Contraseña Nueva");
                return false;
            }

            if (string.IsNullOrEmpty(txtConfirmarContrasena.Text))
            {
                this.MensajeAdvertencia("Debe especificar la confirmación de la contraseña nueva.", "Confimación de Contraseña");
                return false;
            }

            if (txtNuevaContrasena.Text != txtConfirmarContrasena.Text)
            {
                this.MensajeAdvertencia("La contraseña nueva y la confirmación no coinciden, favor de verificar!!!", "Contraseñas no Coinciden");
                return false;
            }


            return true;
        }

        private void frmCambiarContrasena_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ContrasenaActual == Utilidades.ContrasenaDefecto)
            {
                User.CerrarSesion();                
            }

            frmMenu frmMenu = new frmMenu();
            frmMenu.Visible = true;
            this.Dispose();
        }


    }
}
