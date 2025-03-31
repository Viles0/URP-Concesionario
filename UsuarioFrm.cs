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
    public partial class UsuarioFrm: Form
    {
        public UsuarioFrm()
        {
            InitializeComponent();
        }
        CDatos datos = new CDatos();
        UsuarioEn usuarioEntidad = new UsuarioEn();
        private void Limpiar()
        {
            txtUsuario.Focus();
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            MessageBox.Show("Usuario guardado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Complete los campos para guardar un usuario IMBECIL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Usuario guardado");
            usuarioEntidad.Usuario = txtUsuario.Text;
            usuarioEntidad.Contraseña = txtPassword.Text;
            usuarioEntidad.Rolid = (int)cbRol.SelectedValue;
            datos.GuardarUsuario(usuarioEntidad);
            Limpiar();
            MenuFrm usuario = new MenuFrm();
            usuario.Show();
            this.Close();
        }
    }
}
