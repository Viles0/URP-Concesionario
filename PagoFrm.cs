using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URP
{
    public partial class PagoFrm: Form
    {
        public PagoFrm(string marca, string modelo, int año, string color, int cilindraje, string estado, decimal precio)
        {
            InitializeComponent();

            cbMarca.Text = marca;
            cbModelo.Text = modelo;
            cbAño.Text = año.ToString();
            cbColor.Text = color;
            cbCilindraje.Text = cilindraje.ToString();
            cbEstado.Text = estado;
            cbPrecio.Text = precio.ToString();
        }

        int ObtenerIdVehiculo(string marca, string modelo, string año, string color, string cilindraje, string estado)
        {
            int id = -1;
            using (SqlConnection conn = new SqlConnection("Data Source=Vilez\\SQLDB;Initial Catalog=ProyectoCS;Integrated Security=True"))
            {
                string query = "SELECT IdVehiculo FROM Vehiculo WHERE Marca = @Marca AND Modelo = @Modelo AND Año = @Año AND Color = @Color AND Cilindraje = @Cilindraje AND Estado = @Estado";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Marca", marca);
                cmd.Parameters.AddWithValue("@Modelo", modelo);
                cmd.Parameters.AddWithValue("@Año", int.Parse(año));
                cmd.Parameters.AddWithValue("@Color", color);
                cmd.Parameters.AddWithValue("@Cilindraje", int.Parse(cilindraje));
                cmd.Parameters.AddWithValue("@Estado", estado);

                conn.Open();
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    id = Convert.ToInt32(result);
                }
                conn.Close();
            }
            return id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNombres.Text) ||
        string.IsNullOrWhiteSpace(tbApellidos.Text) ||
        string.IsNullOrWhiteSpace(tbTelefono.Text) ||
        string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Por favor llena todos los campos del cliente.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=Vilez\\SQLDB;Initial Catalog=ProyectoCS;Integrated Security=True"))
                {
                    SqlCommand cmd = new SqlCommand("spGenerarFactura", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Nombre", tbNombres.Text.Trim());
                    cmd.Parameters.AddWithValue("@Apellido", tbApellidos.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono", tbTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", tbEmail.Text.Trim());

                    int idVehiculo = ObtenerIdVehiculo(cbMarca.Text, cbModelo.Text, cbAño.Text, cbColor.Text, cbCilindraje.Text, cbEstado.Text);
                    cmd.Parameters.AddWithValue("@IdVehiculo", idVehiculo);

                    decimal monto = decimal.Parse(cbPrecio.Text);
                    cmd.Parameters.AddWithValue("@Monto", monto);

                    cmd.Parameters.AddWithValue("@Fecha", DateTime.Now.Date);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Factura generada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
        !char.IsLetterOrDigit(e.KeyChar) &&
            e.KeyChar != '@' &&
            e.KeyChar != '.' &&
            e.KeyChar != '-' &&
            e.KeyChar != '_')
            {
                e.Handled = true; 
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
