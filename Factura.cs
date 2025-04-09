using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URP
{
    public partial class Factura: Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        private void BuscarFacturaPorId(int idFactura)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=Vilez\\SQLDB;Initial Catalog=ProyectoCS;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand("spBuscarFacturaPorId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdFactura", idFactura);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                conn.Open();
                da.Fill(dt);
                conn.Close();

                dgvFactura.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(tbIdFactura.Text, out int idFactura))
            {
                BuscarFacturaPorId(idFactura);
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID de factura válido.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuFrm menu = new MenuFrm();
            menu.Show();
            this.Hide();
        }
    }
}
