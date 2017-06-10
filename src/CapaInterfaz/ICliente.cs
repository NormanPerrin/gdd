using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Security.Cryptography;

namespace CapaInterfaz
{
    public class ICliente
    {
        #region Metodos/Atributos

        public static string alta(int dni, string nombre, string apellido, string direccion, string mail, int telefono, DateTime fecha_nac, int nro_piso, string dpto ,string localidad, int cod_postal)
        {
            string respuesta = CapaNegocio.NCliente.alta(dni, nombre, apellido, direccion, mail, telefono, fecha_nac, nro_piso, dpto,  localidad, cod_postal);

            return respuesta;
        }

        #endregion

    }
}
