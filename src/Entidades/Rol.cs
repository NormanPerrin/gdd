using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rol
    {
        private int _id;
        private string nombre;
        private int _habilitado;

        private List<Funcionalidad> _funcionalidades; //= new List<Funcionalidad>();
        private string _estado;

        public Rol()
        {
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }

        public List<Funcionalidad> Funcionalidades
        {
            get { return _funcionalidades; }
            set { _funcionalidades = value; }
        }
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
