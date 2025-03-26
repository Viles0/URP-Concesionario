using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace URP.Datos
{
    class CConexion
    {
        private string conn;
        public string strinCon(String nomBD)
        {
            conn = ConfigurationManager.ConnectionStrings[nomBD]
                .ConnectionString;
            return conn;
        }
    }
}
