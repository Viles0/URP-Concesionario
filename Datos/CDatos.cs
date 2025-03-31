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
       public int GuardarRolUsuario(RolUsuarioEn pRol)
        {
            CConexion cn = new CConexion();
            using (SqlConnection Conexion = new
                SqlConnection(cn.strinCon("dbsql")))    
            {
                try
                {
                    using (SqlCommand cmd = new
                        SqlCommand("spGuardarRol", Conexion))
                    {
                        int ultimoRegistro = 0;
                        Conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter IdRol = new
                            SqlParameter("@IdRol", SqlDbType.Int);
                        IdRol.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(IdRol);

                        cmd.Parameters.Add(new
                            SqlParameter("@Nom", pRol.RolNombre));
                        cmd.ExecuteNonQuery();

                        if (IdRol.Value != DBNull.Value)
                            ultimoRegistro = Convert.ToInt32(IdRol.Value);
                        return ultimoRegistro;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 0;
                }
            }
        }
        public void GuardarPermiso(PermisoEn pPermiso)
        {
            CConexion cn = new CConexion();
            using (SqlConnection Conexion = new
                SqlConnection(cn.strinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new
                        SqlCommand("spGuardarPermiso", Conexion))
                    {
                        Conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new
                            SqlParameter("@RolId", pPermiso.RolUsuId));
                        cmd.Parameters.Add(new
                            SqlParameter("@OpcionId", pPermiso.OpcionId));
                        cmd.Parameters.Add(new
                            SqlParameter("@Permitido", pPermiso.Permitido));
                        cmd.ExecuteNonQuery();

                    }

                }
                catch
                {

                }
            }
        }
        public void GuardarVehiculo(VehiculoEn pVehiculo)
        {

            CConexion cn = new CConexion();
            using (SqlConnection Conexion = new
                SqlConnection(cn.strinCon("dbsql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spGuardarVehiculo", Conexion))
                    {
                        Conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdVehiculo", pVehiculo.IdVehiculo);
                        cmd.Parameters.AddWithValue("@Marca", pVehiculo.Marca);
                        cmd.Parameters.AddWithValue("@Modelo", pVehiculo.Modelo);
                        cmd.Parameters.AddWithValue("@Año", pVehiculo.Año);
                        cmd.Parameters.AddWithValue("@Color", pVehiculo.Color);
                        cmd.Parameters.AddWithValue("@Cilindraje", pVehiculo.Cilindraje);
                        cmd.Parameters.AddWithValue("@Precio", pVehiculo.Precio);
                        cmd.Parameters.AddWithValue("@Estado", pVehiculo.Estado);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al guardar vehículo: " + ex.Message);
                }
            }
        }
        public List<VehiculoEn> BuscarVehiculo(VehiculoEn pVehiculo)
        {
            CConexion cn = new CConexion();
            DataTable dt = new DataTable();

            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spBuscarVehiculo", Conexion))
                    {
                        Conexion.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Marca", pVehiculo.Marca);
                        cmd.Parameters.AddWithValue("@Modelo", pVehiculo.Modelo);
                        cmd.Parameters.AddWithValue("@Año", pVehiculo.Año);
                        cmd.Parameters.AddWithValue("@Color", pVehiculo.Color);
                        cmd.Parameters.AddWithValue("@Cilindraje", pVehiculo.Cilindraje);

                        da.SelectCommand = cmd;
                        da.Fill(dt);

                        List<VehiculoEn> vehiculos = (from row in dt.AsEnumerable()
                                                      select new VehiculoEn()
                                                      {
                                                          IdVehiculo = int.Parse(row["IdVehiculo"].ToString()),
                                                          Marca = row["Marca"].ToString(),
                                                          Modelo = row["Modelo"].ToString(),
                                                          Año = int.Parse(row["Año"].ToString()),
                                                          Color = row["Color"].ToString(),
                                                          Cilindraje = int.Parse(row["Cilindraje"].ToString()),
                                                          Precio = decimal.Parse(row["Precio"].ToString()),
                                                          Estado = row["Estado"].ToString()
                                                      }).ToList();

                        return vehiculos;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar vehículos: " + ex.Message);
                    return null;
                }
            }
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
                                 Permitido = bool.Parse(row["Permitido"].ToString()),
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