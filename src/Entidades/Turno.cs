using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {

        #region identificadores

        private int id_turno;
        private int hora_inicio;
        private int hora_fin;
        private string descripcion;
        private decimal valor_km;
        private decimal precio_base;
        private bool habilitado;

        #endregion

        #region constructor

        public Turno()
        {

        }

        #endregion


        #region metodos


        public int Id_turno
        {
            get { return id_turno; }
            set { id_turno = value; }
        }


        public int Hora_inicio
        {
            get { return hora_inicio; }
            set { hora_inicio = value; }
        }

        public int Hora_fin
        {
            get { return hora_fin; }
            set { hora_fin = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public decimal Valor_km
        {
            get { return valor_km; }
            set { valor_km = value; }
        }

        public decimal Precio_base
        {
            get { return precio_base; }
            set { precio_base = value; }
        }

        public bool Habilitado
        {
            get { return habilitado; }
            set { habilitado = value; }
        }

        #endregion

    }
}
