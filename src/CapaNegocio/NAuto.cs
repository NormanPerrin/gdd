using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NAuto
    {


        public static string alta(string patente, string marca, string modelo, string licencia, string rodado)
        {
            CapaDatos.DAuto objeto = new CapaDatos.DAuto();
            return objeto.AgregarAuto(patente, marca, modelo, licencia, rodado);
        }

    }
}
