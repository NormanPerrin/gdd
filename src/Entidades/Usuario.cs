using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private int _id;
        private string _username;
        private string _password;
        private int habilitado;
        private int intentos;

        public Usuario()
        {
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }
        public int Intentos
        {
            get { return intentos; }
            set { intentos = value; }
        }
    }
}
