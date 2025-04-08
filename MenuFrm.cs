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
    public partial class MenuFrm: Form
    {
        public MenuFrm()
        {
            InitializeComponent();
        }
        public MenuFrm(int pIdRol)
        {
          InitializeComponent();
          pIdRol = IdRol;
        }
        int IdRol;
        CDatos datos = new CDatos();
       /* private void ConsultarRol(ToolStripMenuItem pTool)
        {
            var LstOp = datos.SelectOpcion(IdRol);
            foreach (ToolStripMenuItem tool in pTool.DropDownItems)
            {
                foreach (var opc in LstOp)
                {
                    if (opc.OpcionId == Convert.ToInt32(tool.Tag))
                    {
                        if (opc.Permitido)
                            tool.Enabled = false;
                    }
                }
            }
        }*/
        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RolUsuarioFrm formulario = new RolUsuarioFrm();
            formulario.Show();
            this.Close();
        }
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuarioFrm usuario = new UsuarioFrm();
            usuario.Show();
            this.Close();
        }
       /* private void MenuFrm_Load(object sender, EventArgs e)
        {
            ConsultarRol(administraciosTs);
            ConsultarRol(serviciosTs);
            ConsultarRol(mantenimientoTs);
            ConsultarRol(clientesTs);
        }*/

        private void pesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehiculoFrm vehiculo = new VehiculoFrm();
            vehiculo.Show();
            this.Close();
        }

        private void spinningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehiculoFrm vehiculo = new VehiculoFrm();
            vehiculo.Show();
            this.Hide();
        }

        private void pilatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VehiculoFrm vehiculo = new VehiculoFrm();
            vehiculo.Show();
            this.Hide();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            factura.Show();
            this.Hide();
        }
    }
}
