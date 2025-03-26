using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URP.Entidad
{
    class UsuarioEn
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public int Rolid { get; set; }

        public UsuarioEn(int idusuario, string usuario, string contraseña, int rolid)
        {
            IdUsuario = idusuario;
            Usuario = usuario;
            Contraseña = contraseña;
            Rolid = rolid;
        }
    }
}
