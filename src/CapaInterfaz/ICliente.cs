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
        #region atributos

        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private string _mail;
        private int _telefono;
        private DateTime _fecha_nac;
        private int _nro_piso;
        private string _localidad;
        private int _cod_postal;

        #endregion
       
        #region Metodos/Atributos

        public static string alta(int dni, string nombre, string apellido, string direccion, string mail, int telefono, DateTime fecha_nac, int nro_piso, string localidad, int cod_postal)
        {
            string respuesta = CapaNegocio.NCliente.alta(dni, nombre, apellido, direccion, mail, telefono, fecha_nac, nro_piso,  localidad, cod_postal);

            return respuesta;
        }

        #endregion

    }
}
