using Clase04_ejercicio02.BEAN;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04_ejercicio02.DAO
{
    public class RolDAO
    {
        #region Cadena Conexión
        string _stringConnection = ConfigurationManager.ConnectionStrings["connBD"].ConnectionString;
        #endregion

        public List<RolBEAN> ListaRoles()
        {
            List<RolBEAN> lista = new List<RolBEAN>();
            RolBEAN rol;
            try
            {
                using (var conexion = new SqlConnection(_stringConnection))
                {
                    using (var comando = new SqlCommand("SP_ROL_List", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        conexion.Open();
                        using (var datos = comando.ExecuteReader())
                        {
                            while (datos.Read())
                            {
                                rol = new RolBEAN();
                                rol.IdRol = Convert.ToInt32(datos[0]);
                                rol.NombreRol = Convert.ToString(datos[1]);
                                lista.Add(rol);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            return lista;
        }

        public Boolean RegistrarRol(RolBEAN rol)
        {
            bool rpta = false;
            try
            {
                using (var conexion = new SqlConnection(_stringConnection))
                {
                    using (var comando = new SqlCommand("SP_ROL_Insert", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@nombreRol", rol.NombreRol);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        rpta = true;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }

            return rpta;
        }

        //Implementar un metodo que al registrar, automaticamente liste
        public List<RolBEAN> RegistroListaRoles(RolBEAN prolBEAN)
        {
            List<RolBEAN> lista = new List<RolBEAN>();
            RolBEAN rol;
            try
            {
                using (var conexion = new SqlConnection(_stringConnection))
                {
                    using (var comando = new SqlCommand("SP_ROL_InsertListar", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@nombreRol", prolBEAN.NombreRol);
                        conexion.Open();
                        using (var datos = comando.ExecuteReader())
                        {
                            while (datos.Read())
                            {
                                rol = new RolBEAN();
                                rol.IdRol = Convert.ToInt32(datos[0]);
                                rol.NombreRol = Convert.ToString(datos[1]);
                                lista.Add(rol);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }



            return ListaRoles();
        }

        public RolBEAN BuscarRolID (int idROL)
        {
            RolBEAN rol = new RolBEAN();

            try
            {
                using (var conexion = new SqlConnection(_stringConnection))
                {
                    using (var comando = new SqlCommand("SP_ROL_BuscarID", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@idRol", idROL);
                        conexion.Open();
                        using (var datos = comando.ExecuteReader())
                        {
                            if (datos.Read())
                            {
                                rol.IdRol = Convert.ToInt32(datos[0]);
                                rol.NombreRol = datos[1].ToString();
                          }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            return rol;
        }
    }
}