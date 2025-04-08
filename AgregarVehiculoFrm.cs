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
    public partial class AgregarVehiculoFrm: Form
    {
        public AgregarVehiculoFrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuFrm menu = new MenuFrm();
            menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMarca.Text) ||
            string.IsNullOrWhiteSpace(tbModelo.Text) ||
            string.IsNullOrWhiteSpace(tbAño.Text) ||
            string.IsNullOrWhiteSpace(tbColor.Text) ||
            string.IsNullOrWhiteSpace(tbCilindraje.Text) ||
            string.IsNullOrWhiteSpace(tbEstado.Text) ||
            string.IsNullOrWhiteSpace(tbPrecio.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            try
            {
                VehiculoEn vehiculo = new VehiculoEn()
                {
                    Marca = tbMarca.Text,
                    Modelo = tbModelo.Text,
                    Año = int.Parse(tbAño.Text),
                    Color = tbColor.Text,
                    Cilindraje = int.Parse(tbCilindraje.Text),
                    Estado = tbEstado.Text,
                    Precio = int.Parse(tbPrecio.Text)
                };

                CDatos datos = new CDatos();
                datos.GuardarVehiculo(vehiculo);

                MessageBox.Show("Vehículo guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el vehículo: " + ex.Message);
            }
        }
    }
}
