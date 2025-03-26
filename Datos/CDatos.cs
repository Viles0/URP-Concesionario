using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using URP.Entidad;
using System.Windows.Forms;

namespace URP.Datos
{
    class CDatos
    {
      public class DataAccess
      { 
        private readonly string connectionString;
        public DataAccess(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public int GuardarRolUsuario(RolUsuarioEn pRol)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spGuardarRol", conexion))
                    {
                        conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter idRol = new SqlParameter("@IdRol", SqlDbType.Int) { Direction = ParameterDirection.Output };
                        cmd.Parameters.Add(idRol);
                        cmd.Parameters.AddWithValue("@Nom", pRol.RolNombre);
                        cmd.ExecuteNonQuery();
                        return idRol.Value != DBNull.Value ? Convert.ToInt32(idRol.Value) : 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return 0;
                }
            }
        }

        public void GuardarPermiso(PermisoEn pPermiso)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spGuardarPermiso", conexion))
                    {
                        conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RolId", pPermiso.RolUsuId);
                        cmd.Parameters.AddWithValue("@OpcionId", pPermiso.OpcionId);
                        cmd.Parameters.AddWithValue("@Permitido", pPermiso.Permitido);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        public void GuardarVehiculo(VehiculoEn pVehiculo)
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spGuardarVehiculo", conexion))
                    {
                        conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Marca", pVehiculo.Marca);
                        cmd.Parameters.AddWithValue("@Modelo", pVehiculo.Modelo);
                        cmd.Parameters.AddWithValue("@Año", pVehiculo.Año);
                        cmd.Parameters.AddWithValue("@Cilindraje", pVehiculo.Cilindraje);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al guardar vehículo: " + ex.Message);
                }
            }
        }
      }
        public DataTable comboRol()
        {
            CConexion cn = new CConexion();
            DataTable dt = new DataTable();

            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spComboRol", Conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        Conexion.Open();
                        da.Fill(dt);
                    }
                }
                catch
                {

                }
            }

            return dt;
        }
        public void GuardarUsuario(UsuarioEn pUsuario)
        {
            CConexion cn = new CConexion();
            using (SqlConnection Conexion = new
                SqlConnection(cn.strinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new
                        SqlCommand("spGuardarUsuario", Conexion))
                    {
                        Conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new
                            SqlParameter("@Usuario", pUsuario.Usuario));
                        cmd.Parameters.Add(new
                            SqlParameter("@Contra", pUsuario.Contraseña));
                        cmd.Parameters.Add(new
                            SqlParameter("@RolId", pUsuario.Rolid));
                        cmd.ExecuteNonQuery();

                    }

                }
                catch
                {

                }
            }

        }
        public int buscarUsuario(string pUsuario, string pContraseña)
        {
            CConexion cn = new CConexion();
            using (SqlConnection Conexion = new
                SqlConnection(cn.strinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new
                        SqlCommand("spBuscarUsuario", Conexion))
                    {
                        int Id = 0;
                        Conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter IdRol = new
                            SqlParameter("@IdUsuario", SqlDbType.Int);
                        IdRol.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(IdRol);

                        cmd.Parameters.Add(new
                            SqlParameter("@Usuario", pUsuario));
                        cmd.Parameters.Add(new
                            SqlParameter("@Contra", pContraseña));

                        cmd.ExecuteNonQuery();
                        if (IdRol.Value != DBNull.Value)
                            Id = Convert.ToInt32(IdRol.Value);

                        return Id;
                    }

                }
                catch
                {
                    return -1;
                }
            }
        }
        public List<PermisoEn> SelectOpcion(int pIdRol)
        {
            CConexion cn = new CConexion();
            DataTable dt = new DataTable();

            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spSelectOpcion", Conexion))
                    {
                        Conexion.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new
                            SqlParameter("@IdRol", pIdRol));
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        List<PermisoEn> Opcion =
                            (from row in dt.AsEnumerable()
                             select new PermisoEn()
                             {
                                 IdPermiso = int.Parse(row["IdPermiso"].ToString()),
                                 RolUsuId = int.Parse(row["RolUsuId"].ToString()),
                                 OpcionId = int.Parse(row["OpcionId"].ToString()),
                                 Permitido = bool.Parse(row["Permitido"].ToString())
                             }).ToList();
                        return Opcion;
                    }
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}