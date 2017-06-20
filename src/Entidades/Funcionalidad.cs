using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Funcionalidad
    {
        private int _id;
        private string _descripcion;

        private int _habilitado;

        public Funcionalidad()
        {
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        public int Habilitado
        {
            get { return _habilitado; }
            set { _habilitado = value; }
        }
    }
}
