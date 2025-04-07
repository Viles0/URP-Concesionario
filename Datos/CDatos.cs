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
        public DataTable BuscarVehiculo()
        {
            CConexion cn = new CConexion();
            DataTable dt = new DataTable();

            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("dbSql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spBuscarVehiculo", Conexion))
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
        public void GenerarFactura(FacturaGenerarEn pFactura)
        {
            CConexion cn = new CConexion();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("dbsql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spGenerarFactura", Conexion))
                    {
                        Conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Nombre", pFactura.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", pFactura.Apellido);
                        cmd.Parameters.AddWithValue("@Telefono", pFactura.Telefono);
                        cmd.Parameters.AddWithValue("@Email", pFactura.Email);
                        cmd.Parameters.AddWithValue("@IdVehiculo", pFactura.VehiculoId);
                        cmd.Parameters.AddWithValue("@Monto", pFactura.Monto);
                        cmd.Parameters.AddWithValue("@Fecha", pFactura.Fecha);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al generar factura: " + ex.Message);
                }
            }
        }
        public List<FacturaEn> VisualizarFacturas()
        {
            List<FacturaEn> facturas = new List<FacturaEn>();
            CConexion cn = new CConexion();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("dbsql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spVisualizarFacturas", Conexion))
                    {
                        Conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                facturas.Add(new FacturaEn()
                                {
                                    IdFactura = reader.GetInt32(0),
                                    ClienteId = reader.GetInt32(1),
                                    Monto = reader.GetDecimal(2),
                                    Fecha = reader.GetDateTime(3)
                                    
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al visualizar facturas: " + ex.Message);
                }
            }
            return facturas;
        }
        public void GuardarVenta(VentaEn pVenta)
        {
            CConexion cn = new CConexion();
            using (SqlConnection Conexion = new SqlConnection(cn.strinCon("dbsql")))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand("spGuardarVenta", Conexion))
                    {
                        Conexion.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdCliente", pVenta.IdVenta);
                        cmd.Parameters.AddWithValue("@IdVehiculo", pVenta.UsuarioId);
                        cmd.Parameters.AddWithValue("@Fecha", pVenta.VehiculoId);
                        cmd.Parameters.AddWithValue("@Total", pVenta.FacturaId);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al guardar venta: " + ex.Message);
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
    }
}