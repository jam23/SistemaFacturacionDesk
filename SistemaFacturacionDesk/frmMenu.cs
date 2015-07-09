
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (!User.UsuarioLogeado.IsAdmin)
            {
                gbMantenimientos.Visible = false;
            }
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utilidades.PrevenirUsuarioCerrarVentana(e);
        }

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            frmArticulos formArticulos = new frmArticulos();
            formArticulos.Visible = true;
            this.Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes formClientes = new frmClientes();
            formClientes.Visible = true;
            this.Visible = false;
        }

        private void btnCondicionesPago_Click(object sender, EventArgs e)
        {
            frmCondicionesPago formCondicionesPago = new frmCondicionesPago();
            formCondicionesPago.Visible = true;
            this.Visible = false;
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            frmVendedores formVendedores = new frmVendedores();
            formVendedores.Visible = true;
            this.Visible = false;
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            frmFacturacion formFacturacion = new frmFacturacion();
            formFacturacion.Visible = true;
            this.Visible = false;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria formCategoria = new frmCategoria();
            formCategoria.Visible = true;
            this.Visible = false;
        }

      
    }
}
