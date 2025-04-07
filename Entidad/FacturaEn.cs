using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URP.Entidad
{
    class FacturaEn
    {
        public int IdFactura { get; set; }
        public int ClienteId { get; set; }
        public decimal Monto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
