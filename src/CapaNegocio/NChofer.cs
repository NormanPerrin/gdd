using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NChofer
    {
        public static DataTable ObtenerChoferes(String turno)
        {
            DChofer Objeto = new DChofer();
            return Objeto.ObtenerChoferes(turno);
        }
    }
}
