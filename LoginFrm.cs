using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URP.Datos;
using URP.Entidad;

namespace URP
{
    public partial class LoginFrm: Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        CDatos datos = new CDatos();
        UsuarioEn usuarioEntidad = new UsuarioEn();
        int IdRol;

        private bool ValidarCampos()
        {
            IdRol = datos.buscarUsuario(txtUsuario.Text, txtPassword.Text);
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Ingrese usuario");
                txtUsuario.Focus();
                return true;
            }
            else if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Ingrese password");
                txtUsuario.Focus();
                return false;
            }
            else if (IdRol == 0)
            {
                MessageBox.Show("Usuario no registrado");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            { 
                MenuFrm menu = new MenuFrm();
                menu.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuarioFrm usuario = new UsuarioFrm();
            usuario.Show();
            this.Hide();
        }
    }
}
