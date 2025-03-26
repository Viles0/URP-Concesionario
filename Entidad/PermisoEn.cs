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

        public PermisoEn(int idpermiso, int rolusuid, int opcionid, bool permitido)
        {
            IdPermiso = idpermiso;
            RolUsuId = rolusuid;
            OpcionId = opcionid;
            Permitido = permitido;
        }
    }
}
