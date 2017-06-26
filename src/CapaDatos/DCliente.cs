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

        public DataTable ObtenerClientes(DateTime dateFrom, DateTime dateTo)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@dateFrom";
            parametros[0].SqlDbType = SqlDbType.DateTime;
            parametros[0].Value = dateFrom;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@dateTo";
            parametros[1].SqlDbType = SqlDbType.DateTime;
            parametros[1].Value = dateTo;

            DataTable DtResultado = new DataTable("Clientes");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerClientes");
            return DtResultado;
        }

        public string AgregarCliente(int dni, string nombre, string apellido, string direccion, string mail, int telefono, DateTime fecha_nac, int? nro_piso, char? dpto, string localidad, int cod_postal)
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
            parametros[7].Value = (object)nro_piso ?? DBNull.Value;

            parametros[8] = new SqlParameter();
            parametros[8].ParameterName = "@depto";
            parametros[8].SqlDbType = SqlDbType.Char;
            parametros[8].Size = 1;
            parametros[8].Value = (object)dpto ?? DBNull.Value;

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

        public DataTable BuscarCliente(Entidades.Cliente cliente)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@nombre";
            parametros[0].SqlDbType = SqlDbType.NVarChar;
            parametros[0].Size = 255;
            parametros[0].Value = cliente.Nombre;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@apellido";
            parametros[1].SqlDbType = SqlDbType.NVarChar;
            parametros[1].Size = 255;
            parametros[1].Value = cliente.Apellido;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@dni";
            parametros[2].SqlDbType = SqlDbType.Int;
            parametros[2].Value = cliente.Dni;

            DataTable DtResultado = new DataTable("Clientes");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spBuscarCliente");

            return DtResultado;
        }

        public string Modificacion(Entidades.Cliente cliente)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[13];
            
            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@dni";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = cliente.Dni;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@nombre";
            parametros[1].SqlDbType = SqlDbType.NVarChar;
            parametros[1].Size = 255;
            parametros[1].Value = cliente.Nombre;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@apellido";
            parametros[2].SqlDbType = SqlDbType.NVarChar;
            parametros[2].Size = 255;
            parametros[2].Value = cliente.Apellido;

            parametros[3] = new SqlParameter();
            parametros[3].ParameterName = "@direccion";
            parametros[3].SqlDbType = SqlDbType.NVarChar;
            parametros[3].Size = 255;
            parametros[3].Value = cliente.Direccion;

            parametros[4] = new SqlParameter();
            parametros[4].ParameterName = "@mail";
            parametros[4].SqlDbType = SqlDbType.NVarChar;
            parametros[4].Size = 255;
            parametros[4].Value = cliente.Mail;

            parametros[5] = new SqlParameter();
            parametros[5].ParameterName = "@telefono";
            parametros[5].SqlDbType = SqlDbType.Int;
            parametros[5].Value = cliente.Telefono;

            parametros[6] = new SqlParameter();
            parametros[6].ParameterName = "@fecha_nac";
            parametros[6].SqlDbType = SqlDbType.DateTime;
            parametros[6].Value = cliente.Fecha_nac;

            parametros[7] = new SqlParameter();
            parametros[7].ParameterName = "@nro_piso";
            parametros[7].SqlDbType = SqlDbType.Int;
            parametros[7].Value = (object)cliente.Nro_piso ?? DBNull.Value;

            parametros[8] = new SqlParameter();
            parametros[8].ParameterName = "@depto";
            parametros[8].SqlDbType = SqlDbType.Char;
            parametros[8].Size = 1;
            parametros[8].Value = (object)cliente.Depto ?? DBNull.Value;

            parametros[9] = new SqlParameter();
            parametros[9].ParameterName = "@localidad";
            parametros[9].SqlDbType = SqlDbType.NVarChar;
            parametros[9].Size = 255;
            parametros[9].Value = cliente.Localidad;

            parametros[10] = new SqlParameter();
            parametros[10].ParameterName = "@cod_postal";
            parametros[10].SqlDbType = SqlDbType.Int;
            parametros[10].Value = cliente.Cod_postal;

            parametros[11] = new SqlParameter();
            parametros[11].ParameterName = "@id_cliente";
            parametros[11].SqlDbType = SqlDbType.Int;
            parametros[11].Value = cliente.Id_cliente;

            parametros[12] = new SqlParameter();
            parametros[12].ParameterName = "@habilitado";
            parametros[12].SqlDbType = SqlDbType.Bit;
            parametros[12].Value = cliente.Habilitado;

            return Conexion.Ejecutar(parametros, "CRAZYDRIVER.spModificarCliente");
        }

        public string eliminar(int cliente)
        {

            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[1];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@id_cliente";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = cliente;

            return Conexion.Ejecutar(parametros, "CRAZYDRIVER.spEliminarCliente");
        }

        public DataTable ObtenerClientesSinFacturacion(DateTime fechaDesde, DateTime fechaHasta)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[2];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@fechaDesde";
            parametros[0].SqlDbType = SqlDbType.DateTime;
            parametros[0].Value = fechaDesde;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@fechaHasta";
            parametros[1].SqlDbType = SqlDbType.DateTime;
            parametros[1].Size = 255;
            parametros[1].Value = fechaHasta;

            DataTable DtResultado = new DataTable("Clientes");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spBuscarClientesSinFacturacion");

            return DtResultado;
        }


    }
}
