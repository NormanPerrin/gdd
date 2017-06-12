using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
//using System.Windows.Forms;

namespace CapaInterfaz
{
    public class Validador
    {
        public static bool EsMail(string mail) // funciona con formato algo@algo.algo
        {
            bool esMailValido = Regex.IsMatch(mail, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!esMailValido)
            {
                return false;
            }
            return true;
        }

        public static bool EsFecha(string numero) // funciona con formato dd/mm/yyyy
        {
            bool esNumeroValido = Regex.IsMatch(numero, @"^([0][1-9]|[12][0-9]|3[01])(\/|-)([0][1-9]|[1][0-2])\2(\d{4})$", RegexOptions.IgnoreCase);
            if (!esNumeroValido)
            {
                return false;
            }
            return true;
        }

        public static bool EsFechaHora(string numero) // funciona con formato dd-mm-yyyy hh:mm
        {
            bool esNumeroValido = Regex.IsMatch(numero, @"^([1-9]|([012][0-9])|(3[01]))-([0]{0,1}[1-9]|1[012])-\d\d\d\d [012]{0,1}[0-9]:[0-6][0-9]$", RegexOptions.IgnoreCase);
            if (!esNumeroValido)
            {
                return false;
            }
            return true;
        }

        public static bool EsFechaHMS(string numero) // funciona con formato dd/mm/yyyy hh:mm:ss y tambien dd/mm/yyyy
        {
            bool esNumeroValido = Regex.IsMatch(numero, @"^[0-9]{1,2}/[0-9]{1,2}/[0-9]{4}( [0-9]{1,2}:[0-9]{1,2}:[0-9]{1,2})?$", RegexOptions.IgnoreCase);
            if (!esNumeroValido)
            {
                return false;
            }
            return true;
        }

        
        public static bool EsSoloNumeros(string numero) // funciona
        {
            //bool esNumeroValido = Regex.IsMatch(numero, @"^([0-9]+)?$", RegexOptions.IgnoreCase); // <-- este acepta null
            bool esNumeroValido = Regex.IsMatch(numero, @"^\d+$", RegexOptions.IgnoreCase);
            if (!esNumeroValido)
            {
                return false;
            }
            return true;
        }

        public static bool EsCodigoPostal(string cadena)
        {
            bool esCadenaValida = Regex.IsMatch(cadena, @"^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$", RegexOptions.IgnoreCase);
            if (!esCadenaValida)
            {
                return false;
            }
            return true;
        }

        public static bool EsDomicilio(string cadena) // funciona perfecto, me pide letras y numeros
        {
            bool esCadenaValida = Regex.IsMatch(cadena, @"^.*(?=.*[0-9])(?=.*[a-zA-ZñÑ\s]).*$", RegexOptions.IgnoreCase);
            if (!esCadenaValida)
            {
                return false;
            }
            return true;
        }

        public static bool EsNumeroTelefonico(string cadena) // funciona
        {
            bool esCadenaValida = Regex.IsMatch(cadena, @"^[+-]?\d+(\.\d+)?$", RegexOptions.IgnoreCase);
            if (!esCadenaValida)
            {
                return false;
            }
            return true;
        }

        public static bool EsSoloLetras(string cadena) // funciona
        {
            // bool esCadenaValida = Regex.IsMatch(cadena, @"^([a-zA-ZñÑ]+)?$", RegexOptions.IgnoreCase); // <--- permite la cadena vacia
            bool esCadenaValida = Regex.IsMatch(cadena, @"[a-zA-ZñÑ\s]", RegexOptions.IgnoreCase);
            if (!esCadenaValida)
            {
                return false;
            }
            return true;
        }

        public static bool EsCadenaVaciaONula(string cadena)
        {
            return String.IsNullOrEmpty(cadena);
        }

        /*
        // Validación para campos no numericos
        public static void SoloCamposNoNumericos(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        // Validación para campos numéricos
        public static void SoloCamposNumericos(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        */
    }
}
