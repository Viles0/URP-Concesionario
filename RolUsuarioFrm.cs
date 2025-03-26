using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using URP.Datos;
using URP.Entidad;

namespace URP
{
    public partial class RolUsuarioFrm: Form
    {
        public RolUsuarioFrm()
        {
            InitializeComponent();
        }
        RolUsuarioEn rolEntidad = new RolUsuarioEn();
        PermisoEn permisoEntidad = new PermisoEn();
        CDatos datos = new CDatos();
        int IdRol;

        private void GuardarRol()
        {
            if (string.IsNullOrWhiteSpace(TbxUsuario.Text))
            {
                MessageBox.Show("El nombre del rol no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            rolEntidad.RolNombre=TbxUsuario.Text.ToUpper().Trim();
            IdRol = datos.GuardarRolUsuario(rolEntidad);
        }
        private void  GuardarPermiso()
        {
            foreach (Control chk in panel1.Controls)
            {
                permisoEntidad.RolUsuId = IdRol;
                if (chk is CheckBox)
                {
                    permisoEntidad.OpcionId = Convert.ToInt32(chk.Tag);
                    permisoEntidad.Permitido = true;
                    datos.GuardarPermiso(permisoEntidad);
                }
                else
                {
                    permisoEntidad.OpcionId = Convert.ToInt32(chk.Tag);
                    permisoEntidad.Permitido = false;
                    datos.GuardarPermiso(permisoEntidad);
                }
            }
        }
        private void Limpiar()
        {
            TbxUsuario.Text = string.Empty;
            TbxUsuario.Focus();
            foreach(Control chk in panel1.Controls)
            {
                
            }
            MessageBox.Show("Permiso guardado");
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbxUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de rol antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            GuardarRol();
            GuardarPermiso();
            Limpiar();
            MenuFrm usuario = new MenuFrm();
            usuario.Show();
            this.Close();
        }
    }
}
