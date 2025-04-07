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
        public PagoFrm(string marca, string modelo, int año, string color, int cilindraje, string estado)
        {
            InitializeComponent();

            cbMarca.Text = marca;
            cbModelo.Text = modelo;
            cbAño.Text = año.ToString();
            cbColor.Text = color;
            cbCilindraje.Text = cilindraje.ToString();
            cbEstado.Text = estado;
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
                using (SqlConnection conn = new SqlConnection("@\"Data Source= Vilez\\SQLDB;Initial Catalog= ProyectoCS;Integrated Security=True\""))
                {
                    SqlCommand cmd = new SqlCommand("spGenerarFactura", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NombreCliente", tbNombres.Text.Trim());
                    cmd.Parameters.AddWithValue("@ApellidoCliente", tbApellidos.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefono", tbTelefono.Text.Trim());
                    cmd.Parameters.AddWithValue("@Correo", tbEmail.Text.Trim());

                    cmd.Parameters.AddWithValue("@Marca", cbMarca.Text);
                    cmd.Parameters.AddWithValue("@Modelo", cbModelo.Text);
                    cmd.Parameters.AddWithValue("@Año", int.Parse(cbAño.Text));
                    cmd.Parameters.AddWithValue("@Color", cbColor.Text);
                    cmd.Parameters.AddWithValue("@Cilindraje", int.Parse(cbCilindraje.Text));
                    cmd.Parameters.AddWithValue("@Estado", cbEstado.Text);

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
            if (!char.IsLetterOrDigit(e.KeyChar) &&
            e.KeyChar != '.' && e.KeyChar != '-' &&
            e.KeyChar != '_' && e.KeyChar != '@' &&
            e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
