using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NTurno
    {
        #region Metodos/Atributos

            public static DataTable ObtenerTurnos()
            {
                DTurno Objeto = new DTurno();
                return Objeto.ObtenerTurnos();
            }

            public static DataTable CargarValorTurno(String turno)
            {
                DTurno Objeto = new DTurno();
                return Objeto.CargarValorTurno(turno);
            }

            public static DataTable CargarLimitesFechas(String  idTurno)
            {
                DTurno Objeto = new DTurno();
                return Objeto.CargarLimitesFechas(idTurno);
            }

        #endregion

            public static string Alta(Entidades.Turno turno)
            {
                return new DTurno().Alta(turno);
            }

            public static object BusquedaTurno(Entidades.Turno turno)
            {
                return new DTurno().BusquedaTurno(turno);
            }

            public static string Eliminar(int id_turno)
            {
                return new DTurno().Eliminar(id_turno);
            }

            public static string Modificar(Entidades.Turno turno)
            {
                return new DTurno().Modificar(turno);
            }
    }
}
