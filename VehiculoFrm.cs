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
    public partial class VehiculoFrm: Form
    {
        public VehiculoFrm()
        {
            InitializeComponent();
        }
        CDatos datos = new CDatos();
        VehiculoEn vehiculoEntida = new VehiculoEn();
        private void CargarVehiculo()
        {
            DataTable dt = datos.BuscarVehiculo();

            if (dt != null && dt.Rows.Count > 0)
            {
                cbMarca.DataSource = dt.DefaultView.ToTable(true, "Marca");
                cbMarca.DisplayMember = "Marca";
                cbMarca.ValueMember = "Marca";

                cbModelo.DataSource = dt.DefaultView.ToTable(true, "Modelo");
                cbModelo.DisplayMember = "Modelo";
                cbModelo.ValueMember = "Modelo";

                cbAño.DataSource = dt.DefaultView.ToTable(true, "Año");
                cbAño.DisplayMember = "Año";
                cbAño.ValueMember = "Año";

                cbColor.DataSource = dt.DefaultView.ToTable(true, "Color");
                cbColor.DisplayMember = "Color";
                cbColor.ValueMember = "Color";

                cbCilindraje.DataSource = dt.DefaultView.ToTable(true, "Cilindraje");
                cbCilindraje.DisplayMember = "Cilindraje";
                cbCilindraje.ValueMember = "Cilindraje";

                cbEstado.DataSource = dt.DefaultView.ToTable(true, "Estado");
                cbEstado.DisplayMember = "Estado";
                cbEstado.ValueMember = "Estado";

                cbPrecio.DataSource = dt.DefaultView.ToTable(true, "Precio");
                cbPrecio.DisplayMember = "Precio";
                cbPrecio.ValueMember = "Precio";
            }
            else
            {
                MessageBox.Show("No se encontraron vehículos.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CargarVehiculo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarVehiculoFrm agr = new AgregarVehiculoFrm();
            agr.Show();
            this.Hide();
        }

        private void VehiculoFrm_Load(object sender, EventArgs e)
        {
            CargarVehiculo();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string marca = "Posrche";
            string modelo = "918 Spyder";
            int año = 2015;
            string color = "Gris";
            int cilindraje = 2900;
            string estado = "Usado";
            decimal precio = 520000;

            PagoFrm pago = new PagoFrm(marca,modelo,año,color,cilindraje,estado,precio);
            pago.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string marca = "Audi";
            string modelo = "R8";
            int año = 2018;
            string color = "Azul";
            int cilindraje = 3000;
            string estado = "Usado";
            decimal precio = 240000;

            PagoFrm pago = new PagoFrm(marca,modelo,año,color,cilindraje,estado,precio);
            pago.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string marca = "BMW";
            string modelo = "M3 ";
            int año = 2024;
            string color = "Negro";
            int cilindraje = 2900;
            string estado = "Nuevo";
            decimal precio = 320000;

            PagoFrm pago = new PagoFrm(marca,modelo,año,color,cilindraje,estado,precio);
            pago.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string marca = "Ferrari";
            string modelo = "Stradale";
            int año = 2023;
            string color = "Rojo";
            int cilindraje = 3500;
            string estado = "Nuevo";
            decimal precio = 2500000;

            PagoFrm pago = new PagoFrm(marca,modelo,año,color,cilindraje,estado,precio);
            pago.Show();
            this.Hide();
        }
        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPorsche.Visible = false;
            pictureBoxAudi.Visible = false;
            pictureBoxBmw.Visible = false;
            pictureBoxFerrari.Visible = false;

            string marcaSeleccionada = cbMarca.Text;

            switch (marcaSeleccionada)
            {
                case "PORSCHE":
                    pictureBoxPorsche.Visible = true;
                    break;
                case "AUDI":
                    pictureBoxAudi.Visible = true;
                    break;
                case "BMW":
                    pictureBoxBmw.Visible = true;
                    break;
                case "FERRARI":
                    pictureBoxFerrari.Visible = true;
                    break;
            }
        }

        private void cbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPorsche.Visible = false;
            pictureBoxAudi.Visible = false;
            pictureBoxBmw.Visible = false;
            pictureBoxFerrari.Visible = false;

            string modeloSeleccionado = cbModelo.Text;

            switch (modeloSeleccionado)
            {
                case "918 SPYDER":
                    pictureBoxPorsche.Visible = true;
                    break;
                case "R8":
                    pictureBoxAudi.Visible = true;
                    break;
                case "M3":
                    pictureBoxBmw.Visible = true;
                    break;
                case "STRADALE":
                    pictureBoxFerrari.Visible = true;
                    break;
            }
        }

        private void cbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPorsche.Visible = false;
            pictureBoxAudi.Visible = false;
            pictureBoxBmw.Visible = false;
            pictureBoxFerrari.Visible = false;

            string AñoSeleccionado = cbAño.Text;

            switch (AñoSeleccionado)
            {
                case "2015":
                    pictureBoxPorsche.Visible = true;
                    break;
                case "2018":
                    pictureBoxAudi.Visible = true;
                    break;
                case "2024":
                    pictureBoxBmw.Visible = true;
                    break;
                case "2023":
                    pictureBoxFerrari.Visible = true;
                    break;
            }
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPorsche.Visible = false;
            pictureBoxAudi.Visible = false;
            pictureBoxBmw.Visible = false;
            pictureBoxFerrari.Visible = false;

            string ColorSeleccionado = cbColor.Text;

            switch (ColorSeleccionado)
            {
                case "GRIS":
                    pictureBoxPorsche.Visible = true;
                    break;
                case "AZUL":
                    pictureBoxAudi.Visible = true;
                    break;
                case "NEGRO":
                    pictureBoxBmw.Visible = true;
                    break;
                case "ROJO":
                    pictureBoxFerrari.Visible = true;
                    break;
            }
        }
        private void cbCilindraje_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPorsche.Visible = false;
            pictureBoxAudi.Visible = false;
            pictureBoxBmw.Visible = false;
            pictureBoxFerrari.Visible = false;

            string CilindrajeSeleccionado = cbCilindraje.Text;

            switch (CilindrajeSeleccionado)
            {
                case "2900":
                    pictureBoxPorsche.Visible = true;
                    pictureBoxBmw.Visible = true;
                    break;
                case "3000":
                    pictureBoxAudi.Visible = true;
                    break;
                case "3500":
                    pictureBoxFerrari.Visible = true;
                    break;
            }
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPorsche.Visible = false;
            pictureBoxAudi.Visible = false;
            pictureBoxBmw.Visible = false;
            pictureBoxFerrari.Visible = false;

            string EstadoSeleccionado = cbEstado.Text;

            switch (EstadoSeleccionado)
            {
                case "Usado":
                    pictureBoxAudi.Visible = true;
                    pictureBoxPorsche.Visible = true;
                    break;
                case "Nuevo":
                    pictureBoxFerrari.Visible = true;
                    pictureBoxBmw.Visible = true;
                    break;
            }
        }

        private void cbPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxPorsche.Visible = false;
            pictureBoxAudi.Visible = false;
            pictureBoxBmw.Visible = false;
            pictureBoxFerrari.Visible = false;

            string PrecioSeleccionado = cbPrecio.Text;

            switch (PrecioSeleccionado)
            {
                case "520000":
                    pictureBoxPorsche.Visible = true;
                    break;
                case "240000":
                    pictureBoxAudi.Visible = true;
                    break;
                case "320000":
                    pictureBoxBmw.Visible = true;
                    break;
                case "2500000":
                    pictureBoxFerrari.Visible = true;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuFrm menu = new MenuFrm();
            menu.Show();
            this.Hide();
        }
    }
}
