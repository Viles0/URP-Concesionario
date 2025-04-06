using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URP
{
    public partial class VehiculoFrm: Form
    {
        public VehiculoFrm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PagoFrm pago = new PagoFrm();
            pago.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarVehiculoFrm agr = new AgregarVehiculoFrm();
            agr.Show();
            this.Hide();
        }

        private void VehiculoFrm_Load(object sender, EventArgs e)
        {
       
        }
    }
}
