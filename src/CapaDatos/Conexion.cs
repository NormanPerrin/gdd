using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class Conexion
    {
        #region Declaracion de Variables

            SqlConnection sqlConexion = null;
            SqlCommand Comando = null;
        string Cn = string.Empty;

        #endregion

        #region Constructor

            public Conexion()
            {
                Cn = Properties.Settings.Default.Cn;
            }

        #endregion

        #region Mensajes/Atributos

            public string Ejecutar(SqlParameter[] parametros, string nombreProcedimiento) // valido para: insert, update y delete
            {
                string respuesta = String.Empty;
                try
                {
                    sqlConexion = new SqlConnection(Cn); // instanciamos el objeto conexion con la cadena de conexion
                    Comando = new SqlCommand(); // instanciamos el objeto comando con el TSQL y conexion a utilizar
                    Comando.Connection = sqlConexion;
                    sqlConexion.Open(); // abrimos la conexion
                    Comando.CommandType = CommandType.StoredProcedure; // asignamos el tipo de comando a ejecutar
                    Comando.CommandText = nombreProcedimiento; // agregamos el nombre del Srore procedure
                    Comando.Parameters.AddRange(parametros); // agregmos los parametros a ejecutar                
                    // ejecutamos el TSQL(Transaction SQL) en el servidor
                    respuesta = Comando.ExecuteNonQuery() == 1 ?
                        "No se ha podido ejecutar la transaccion": // si no se logro ejecutar
                        "La transaccion se ha realizado con exito"; // si se logro ejecutar
                }
                catch (Exception ex)
                {
                   return ex.Message;
                }

                finally
                {
                    sqlConexion.Dispose();
                    Comando.Dispose();
                    if(sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
                }
                return respuesta;
            }

            public int Ejecutar(string nombreProcedimiento)
            {
                int respuesta = 0;
                try
                {
                    sqlConexion = new SqlConnection(Cn); // instanciamos el objeto conexion con la cadena de conexion
                    Comando = new SqlCommand(); // instanciamos el objeto comando con el TSQL y conexion a utilizar
                    Comando.Connection = sqlConexion;
                    sqlConexion.Open(); // abrimos la conexion
                    Comando.CommandType = CommandType.StoredProcedure; // asignamos el tipo de comando a ejecutar
                    Comando.CommandText = nombreProcedimiento; // agregamos el nombre del Srore procedure              
                    // ejecutamos el TSQL(Transaction SQL) en el servidor
                    respuesta = Comando.ExecuteNonQuery() == 1 ?
                        1 : // si no se logro ejecutar
                        0; // si se logro ejecutar
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Exception caught.", ex);
                    //throw new Exception(ex.Message); --> tira un error, investigar luego porque
                    //rpta = ex.Message; --> quedo obsoleto ya no muestro el error
                    respuesta = -1; // termino por excepcion
                }

                finally
                {
                    sqlConexion.Dispose();
                    Comando.Dispose();
                    if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
                }
                return respuesta;
            }

            public DataTable RetornarTabla(SqlParameter[] parametros, string nombreProcedimiento) // valido para: select
            {
                DataTable TablaDeDatos = null;
                SqlDataAdapter Adaptador = null;
                try
                {
                    TablaDeDatos = new DataTable(); // creo una instancia de DataTable
                    sqlConexion = new SqlConnection(Cn); // instanciamos el objeto conexion con la cadena de conexion
                    Comando = new SqlCommand(); // instanciamos el objeto comando con el TSQL y conexion a utilizar
                    Comando.Connection = sqlConexion;
                    Comando.CommandType = CommandType.StoredProcedure; // asignamos el tipo de comando a ejecutar
                    Comando.CommandText = nombreProcedimiento; // agregamos el nombre del Srore procedure
                    Comando.Parameters.AddRange(parametros); // agregmos los parametros a ejecutar         
                    Adaptador = new SqlDataAdapter(Comando); // instanciamos el objeto Adaptador con el comando a utilizar
                    Adaptador.Fill(TablaDeDatos); // llenamos el la tabla de datos con el Adaptador de datos
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    sqlConexion.Dispose();
                    Comando.Dispose();
                    Adaptador.Dispose();
                    if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
                }
                return TablaDeDatos;
            }

            public DataTable RetornarTabla(string nombreProcedimiento) // valido para: select
            {
                DataTable TablaDeDatos = null;
                SqlDataAdapter Adaptador = null;
                try
                {
                    TablaDeDatos = new DataTable(); // creo una instancia de DataTable
                    sqlConexion = new SqlConnection(Cn); // instanciamos el objeto conexion con la cadena de conexion
                    Comando = new SqlCommand(); // instanciamos el objeto comando con el TSQL y conexion a utilizar
                    Comando.Connection = sqlConexion;
                    Comando.CommandType = CommandType.StoredProcedure; // asignamos el tipo de comando a ejecutar
                    Comando.CommandText = nombreProcedimiento; // agregamos el nombre del Srore procedure
                    Adaptador = new SqlDataAdapter(Comando); // instanciamos el objeto Adaptador con el comando a utilizar
                    Adaptador.Fill(TablaDeDatos); // llenamos el la tabla de datos con el Adaptador de datos
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    sqlConexion.Dispose();
                    Comando.Dispose();
                    Adaptador.Dispose();
                    if (sqlConexion.State == ConnectionState.Open) sqlConexion.Close();
                }
                return TablaDeDatos;
            }

        #endregion
    }
}
