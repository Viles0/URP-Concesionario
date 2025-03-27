using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URP.Entidad
{
    class PermisoEn
    {
        public int IdPermiso { get; set; }
        public int RolUsuId { get; set; }
        public int OpcionId { get; set; }
        public bool Permitido { get; set; }
    }
}
