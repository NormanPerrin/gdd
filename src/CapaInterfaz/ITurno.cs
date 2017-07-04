using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaNegocio;
using System.Windows.Forms;

namespace CapaInterfaz
{
    public class ITurno
    {
        #region Metodos/Atributos

        static Dictionary<String, String> turnos = new Dictionary<String, String> {};

        public static void CargarTurnos(ComboBox cbxTurnos)
        {
            DataTable Datos = CapaNegocio.NTurno.ObtenerTurnos();
            turnos.Clear();
            if (Datos.Rows.Count != 0)
            {
                int cantidadDeItems = Datos.Rows.Count;
                for (int i = 0; i < cantidadDeItems; i++)
                {
                    turnos.Add(Datos.Rows[i][0].ToString(), Datos.Rows[i][1].ToString());
                    cbxTurnos.Items.Add(Datos.Rows[i][1]);
                }
                cbxTurnos.SelectedIndex = 0;
            }
        }

        public static String getIdTurnoActual(String nombreTurno)
        {
            return turnos.FirstOrDefault(x => x.Value == nombreTurno).Key;
        }

        public static void CargarValorTurno(TextBox costo, int kms, String turno)
        {
            DataTable Datos = CapaNegocio.NTurno.CargarValorTurno(turno);
            if (Datos.Rows.Count != 0)
            {
                float precioBase = float.Parse(Datos.Rows[0][0].ToString());
                float precioPorKm = float.Parse(Datos.Rows[0][1].ToString());
                costo.Text = (precioBase + precioPorKm * kms).ToString();
            }
        }

        public static void CargarLimitesFechas(DateTimePicker dateFrom, DateTimePicker dateTo, String idTurno, DateTime now)
        {
            DataTable Datos = CapaNegocio.NTurno.CargarLimitesFechas(idTurno);
            if (Datos.Rows.Count != 0)
            {
                int horaInicio = Int32.Parse(Datos.Rows[0][0].ToString());
                int horaFin = Int32.Parse(Datos.Rows[0][1].ToString());

                dateFrom.MaxDate = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);
                dateTo.MaxDate = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);

                dateFrom.MinDate = new DateTime(now.Year, now.Month, now.Day, horaInicio, 0, 0);
                dateTo.MinDate = new DateTime(now.Year, now.Month, now.Day, horaInicio, 0, 0);

                dateFrom.MaxDate = new DateTime(now.Year, now.Month, now.Day, horaFin - 1, 59, 59);
                dateTo.MaxDate = new DateTime(now.Year, now.Month, now.Day, horaFin - 1, 59, 59);

                dateFrom.Value = dateFrom.MinDate;
                dateTo.Value = dateTo.MaxDate;
            }
        }

        #endregion

        public static string Alta(Entidades.Turno turno)
        {
            string respuesta = CapaNegocio.NTurno.Alta(turno);

            return respuesta;
        }

        public static void BusquedaTurno(DataGridView tablaTurnos, Entidades.Turno turno)
        {
            tablaTurnos.DataSource = CapaNegocio.NTurno.BusquedaTurno(turno);
        }

        public static string eliminar(int id_turno)
        {
            return CapaNegocio.NTurno.Eliminar(id_turno);
        }

        public static string Modificar(Entidades.Turno turno)
        {
            return CapaNegocio.NTurno.Modificar(turno);
        }
    }
}
