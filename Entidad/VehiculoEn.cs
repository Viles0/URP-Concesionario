using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URP.Entidad
{
    class VehiculoEn
    {
        public int IdVehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Color { get; set; }
        public double Cilindraje { get; set; }

        public VehiculoEn(string marca, string modelo, int año, string color, double cilindraje)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Color = color;
            Cilindraje = cilindraje;
        }

    }
}
