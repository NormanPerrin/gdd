﻿using System;
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
            parametros[4].SqlDbType = SqlDbType.Date;
            parametros[4].Value = fechaDesde;

            parametros[5] = new SqlParameter();
            parametros[5].ParameterName = "@fechaHasta";
            parametros[5].SqlDbType = SqlDbType.Date;
            parametros[5].Value = fechaHasta;

            parametros[6] = new SqlParameter();
            parametros[6].ParameterName = "@kms";
            parametros[6].SqlDbType = SqlDbType.Int;
            parametros[6].Value = kms;

            Conexion.Ejecutar(parametros, "CRAZYDRIVER.spagregarviaje");
        }
    }
}