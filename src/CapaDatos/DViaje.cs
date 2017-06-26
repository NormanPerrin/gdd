using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DViaje
    {
        public DViaje()
        {
        }

        public void AgregarFacturacion(String idCliente, DateTime fechaAhora, DateTime fechaDesde, DateTime fechaHasta)
        {
            Conexion Conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[4];
            
            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@fechaDesde";
            parametros[0].SqlDbType = SqlDbType.DateTime;
            parametros[0].Value = fechaDesde;

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@fechaHasta";
            parametros[1].SqlDbType = SqlDbType.DateTime;
            parametros[1].Value = fechaHasta;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@fechaCreado";
            parametros[2].SqlDbType = SqlDbType.DateTime;
            parametros[2].Value = fechaAhora;

            parametros[3] = new SqlParameter();
            parametros[3].ParameterName = "@clienteid";
            parametros[3].SqlDbType = SqlDbType.Int;
            parametros[3].Value = Int32.Parse(idCliente);

            Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spAltaFactura");
        }

        public void AgregarViaje(String idcliente, String idchofer, String turno, String idauto, DateTime fechaDesde, DateTime fechaHasta, int kms)
        {
            Conexion Conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[7];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@idcliente";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = Int32.Parse(idcliente);

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@idchofer";
            parametros[1].SqlDbType = SqlDbType.Int;
            parametros[1].Value = Int32.Parse(idchofer);

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@turno";
            parametros[2].SqlDbType = SqlDbType.Int;
            parametros[2].Value = Int32.Parse(turno);

            parametros[3] = new SqlParameter();
            parametros[3].ParameterName = "@idauto";
            parametros[3].SqlDbType = SqlDbType.Int;
            parametros[3].Value = Int32.Parse(idauto);

            parametros[4] = new SqlParameter();
            parametros[4].ParameterName = "@fechaDesde";
            parametros[4].SqlDbType = SqlDbType.DateTime;
            parametros[4].Value = fechaDesde;

            parametros[5] = new SqlParameter();
            parametros[5].ParameterName = "@fechaHasta";
            parametros[5].SqlDbType = SqlDbType.DateTime;
            parametros[5].Value = fechaHasta;

            parametros[6] = new SqlParameter();
            parametros[6].ParameterName = "@kms";
            parametros[6].SqlDbType = SqlDbType.Int;
            parametros[6].Value = kms;

            Conexion.Ejecutar(parametros, "CRAZYDRIVER.spAgregarViaje");
        }

        public DataTable ObtenerListaViajesPorChofer(String idCliente, DateTime fechaDesde, DateTime fechaHasta)
        {
            Conexion Conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[3];

            parametros[0] = new SqlParameter();
            parametros[0].ParameterName = "@clienteid";
            parametros[0].SqlDbType = SqlDbType.Int;
            parametros[0].Value = Int32.Parse(idCliente);

            parametros[1] = new SqlParameter();
            parametros[1].ParameterName = "@fechaDesde";
            parametros[1].SqlDbType = SqlDbType.DateTime;
            parametros[1].Value = fechaDesde;

            parametros[2] = new SqlParameter();
            parametros[2].ParameterName = "@fechaHasta";
            parametros[2].SqlDbType = SqlDbType.DateTime;
            parametros[2].Value = fechaHasta;

            DataTable DtResultado = new DataTable("Viajes");
            DtResultado = Conexion.RetornarTabla(parametros, "CRAZYDRIVER.spObtenerViajesEntreFechasYCliente");
            return DtResultado;
        }
    }
}
