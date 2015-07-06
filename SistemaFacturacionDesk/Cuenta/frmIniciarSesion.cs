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
    public partial class frmIniciarSesion : Form
    {
        EntitiesFACTURACION db = new EntitiesFACTURACION();
        public frmIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreUsuario.Text))
            {
                this.MensajeAdvertencia("Debe Ingresar el Nombre de Usuario", "Nombre de Usuario");
                return;
            }
            else if (string.IsNullOrEmpty(txtContrasena.Text))
            {
                this.MensajeAdvertencia("Debe Ingresar la contraseña", "contraseña");
                return;
            }

            VENDEDORES vendedor = null;
            try
            {
                vendedor = db.VENDEDORES.Where(v => v.nombreUsuario.Equals(txtNombreUsuario.Text) && v.contrasena.Equals(txtContrasena.Text)).FirstOrDefault();
            }
            catch (Exception ex)
            {
                this.MensajeError("Ocurrio algún error, favor de intentar nuevamente.", "Error Sistema.");
            }


            if (vendedor == null)
            {
                this.MensajeError("No se pudo iniciar sesión, verificar Usuario/Constraseña");
                return;
            }
            else if (vendedor.estado != "A")
            {
                this.MensajeError("Este usuario esta Inactivo, ponerse en contacto con su supervisor.");
                return;
            }
            else
            {
                User.IniciarSesion(vendedor.id);
            }

        
                this.Visible = false;
                frmMenu frmMenu = new frmMenu();
                frmMenu.Visible = true;
          


        }







    }
}
