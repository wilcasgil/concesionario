using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Ruta
{
    public class MetodosCRUDruta
    {
            //Crear tipo comando INSERT
            public static SqlCommand CrearComandoInsert_r()
            {
                string _cadenaConexion = Configuracion.CadenaConexion;

                SqlConnection _conexion = new SqlConnection(_cadenaConexion);

                SqlCommand _comando = new SqlCommand("registrarRuta", _conexion);

                _comando.CommandType = CommandType.StoredProcedure;

                return _comando;
            }

            //Ejecucion tipo comando INSERT
            public static int EjecutarComandoInsert_r(SqlCommand comando)
            {
                try
                {
                    comando.Connection.Open();
                    return comando.ExecuteNonQuery();
                }
                catch { throw; }
                finally
                {
                    comando.Connection.Dispose();
                    comando.Connection.Close();
                }
            }

            //Crear tipo comando UPDATE
            public static SqlCommand CrearComandoUpdate_r()
            {
                string _cadenaConexion = Configuracion.CadenaConexion;

                SqlConnection _conexion = new SqlConnection(_cadenaConexion);

                SqlCommand _comando = new SqlCommand("actualizarRuta", _conexion);

                _comando.CommandType = CommandType.StoredProcedure;

                return _comando;
            }

            //Ejecucion tipo comando UPDATE
            public static int EjecutarComandoUpdate_r(SqlCommand comando)
            {
                try
                {
                    comando.Connection.Open();
                    return comando.ExecuteNonQuery();
                }
                catch { throw; }
                finally
                {
                    comando.Connection.Dispose();
                    comando.Connection.Close();
                }
            }

            //Crear tipo comando DELETE
            public static SqlCommand CrearComandoDelete_r()
            {
                string _cadenaConexion = Configuracion.CadenaConexion;

                SqlConnection _conexion = new SqlConnection(_cadenaConexion);

                SqlCommand _comando = new SqlCommand("eliminarRuta", _conexion);

                _comando.CommandType = CommandType.StoredProcedure;

                return _comando;
            }

            //Ejecucion tipo comando DELETE
            public static int EjecutarComandoDelete_r(SqlCommand comando)
            {
                try
                {
                    comando.Connection.Open();
                    return comando.ExecuteNonQuery();
                }
                catch { throw; }
                finally
                {
                    comando.Connection.Dispose();
                    comando.Connection.Close();
                }
            }

            //Crear tipo comando SELECT
            public static SqlCommand CrearComandoSelect_r()
            {
                //Usar la conexion
                string _cadenaConexion = Configuracion.CadenaConexion;
                SqlConnection _conexion = new SqlConnection();
                _conexion.ConnectionString = _cadenaConexion;

                //Crear la instruccion select
                SqlCommand _comando = new SqlCommand();
                _comando = _conexion.CreateCommand();
                _comando.CommandType = CommandType.Text;
                return _comando;
            }

            //Ejecucion tipo comando SELECT
            public static DataTable EjecutarComandoSelect_r(SqlCommand comando)
            {
                DataTable _tabla = new DataTable();

                try
                {
                    comando.Connection.Open();
                    SqlDataAdapter adaptador = new SqlDataAdapter();
                    adaptador.SelectCommand = comando;
                    adaptador.Fill(_tabla);
                }
                catch (Exception Ex) { throw Ex; }
                finally { comando.Connection.Close(); }

                return _tabla;
            }
    }
}
