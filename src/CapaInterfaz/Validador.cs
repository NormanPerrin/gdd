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
        public static bool EsMail(string mail)
        {
            bool esMailValido = Regex.IsMatch(mail, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (!esMailValido)
            {
                return false;
            }
            return true;
        }

        public static bool EsFecha(string numero)
        {
            bool esNumeroValido = Regex.IsMatch(numero, @"^(0?[1-9]|1[0-9]|2|2[0-9]|3[0-1])/(0?[1-9]|1[0-2])/(d{2}|d{4})$", RegexOptions.IgnoreCase);
            if (!esNumeroValido)
            {
                return false;
            }
            return true;
        }

        public static bool EsSoloNumeros(string numero)
        {
            bool esNumeroValido = Regex.IsMatch(numero, @"[0-9]{1,9}(\.[0-9]{0,2})?$", RegexOptions.IgnoreCase);
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

        public static bool EsDomicilio(string cadena)
        {
            bool esCadenaValida = Regex.IsMatch(cadena, @"^.*(?=.*[0-9])(?=.*[a-zA-ZñÑ\s]).*$", RegexOptions.IgnoreCase);
            if (!esCadenaValida)
            {
                return false;
            }
            return true;
        }

        public static bool EsNumeroTelefonico(string cadena)
        {
            bool esCadenaValida = Regex.IsMatch(cadena, @"^[+-]?\d+(\.\d+)?$", RegexOptions.IgnoreCase);
            if (!esCadenaValida)
            {
                return false;
            }
            return true;
        }

        public static bool EsSoloLetras(string cadena)
        {
            bool esCadenaValida = Regex.IsMatch(cadena, @"[a-zA-ZñÑ\s]", RegexOptions.IgnoreCase);
            if (!esCadenaValida)
            {
                return false;
            }
            return true;
        }

        public static bool EsCadenaVaciaONula(string cadena)
        {
            if(!String.IsNullOrEmpty(cadena))
                return true;
            return false;
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
