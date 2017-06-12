using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int id_cliente;
        private int dni;
        private string nombre;
        private string apellido;
        private string mail;
        private int telefono;
        private DateTime ? fecha_nac;
        private string direccion;
        private int ? nro_piso;
        private char ? depto;
        private string localidad;
        private int cod_postal;
        private bool habilitado;

        public Cliente()
        {
            this.fecha_nac = null;

        }


        public int Cod_postal
        {
            get { return cod_postal; }
            set { cod_postal = value; }
        }


        public int Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public DateTime ? Fecha_nac
        {
            get { return fecha_nac; }
            set { fecha_nac = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int ? Nro_piso
        {
            get { return nro_piso; }
            set { nro_piso = value; }
        }

        public char ? Depto
        {
            get { return depto; }
            set { depto = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }

        public static int? Piso(string s)
        {

            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }

        public static char? Dpto(string p)
        {
            char dpto;
            if (char.TryParse(p, out dpto)) return dpto;
            return null;
        }
       
        public Cliente asignarCliente(int dni,string nombre,string apellido,string mail,int tel,DateTime fecha,string dir,bool habilitado,int? piso,char? dpto,string loc,int cp)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Mail = mail;
            this.Telefono = tel;
            this.Fecha_nac = fecha;
            this.Direccion = dir;
            this.Habilitado = habilitado;
            this.Nro_piso = piso;
            this.Depto = dpto;
            this.Localidad = loc;
            this.Cod_postal = cp;

            return this;

        }
    }
}
