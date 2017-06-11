using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DCliente
    {
        public DCliente()
        {
        }

        public DataTable ObtenerClientes()
        {
            Conexion Conexion = new Conexion();
            DataTable DtResultado = new DataTable("Clientes");
            DtResultado = Conexion.RetornarTabla("CRAZYDRIVER.spObtenerClientes");
            return DtResultado;
        }

        public string AgregarCliente(int dni, string nombre, string apellido, string direccion, string mail, int telefono, DateTime fecha_nac, int nro_piso, string dpto, string localidad, int cod_postal)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[11];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@dni";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = dni;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@nombre";
            parametros[1].SqlDbType = SqlDbType.NVarChar;
            parametros[1].Size = 255;
            parametros[1].Value = nombre;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@apellido";
            parametros[2].SqlDbType = SqlDbType.NVarChar;
            parametros[2].Size = 255;
            parametros[2].Value = apellido;

            parametros[3] = new SqlParameter();
            parametros[3].ParameterName = "@direccion";
            parametros[3].SqlDbType = SqlDbType.NVarChar;
            parametros[3].Size = 255;
            parametros[3].Value = direccion;

            parametros[4] = new SqlParameter();
            parametros[4].ParameterName = "@mail";
            parametros[4].SqlDbType = SqlDbType.NVarChar;
            parametros[4].Size = 255;
            parametros[4].Value = mail;

            parametros[5] = new SqlParameter();
            parametros[5].ParameterName = "@telefono";
            parametros[5].SqlDbType = SqlDbType.Int;
            parametros[5].Value = telefono;

            parametros[6] = new SqlParameter();
            parametros[6].ParameterName = "@fecha_nac";
            parametros[6].SqlDbType = SqlDbType.DateTime;
            parametros[6].Value = fecha_nac;

            parametros[7] = new SqlParameter();
            parametros[7].ParameterName = "@nro_piso";
            parametros[7].SqlDbType = SqlDbType.Int;
            parametros[7].Value = nro_piso;

            parametros[8] = new SqlParameter();
            parametros[8].ParameterName = "@depto";
            parametros[8].SqlDbType = SqlDbType.Char;
            parametros[8].Size = 1;
            parametros[8].Value = dpto;

            parametros[9] = new SqlParameter();
            parametros[9].ParameterName = "@localidad";
            parametros[9].SqlDbType = SqlDbType.NVarChar;
            parametros[9].Size = 255;
            parametros[9].Value = localidad;

            parametros[10] = new SqlParameter();
            parametros[10].ParameterName = "@cod_postal";
            parametros[10].SqlDbType = SqlDbType.Int;
            parametros[10].Value = cod_postal;

            return Conexion.Ejecutar(parametros, "CRAZYDRIVER.spAgregarCliente");
        }
    }
}
