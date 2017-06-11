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

        #endregion
    }
}
