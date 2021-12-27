using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Turno
    {
        private int Nro;
        private DateTime Fecha;
        private TimeSpan Hora;
        private int IdServicio;
        private int NroHistialClinico;

        public Turno()
        {

        }
        public int NroTurno
        {
            get => Nro;
            set => Nro = value;
        }
        public DateTime FechaTurno
        {
            get => Fecha.Date;
            set => Fecha = value;
        }
        public TimeSpan HoraTurno
        {
            get => Hora;
            set => Hora = value;
        }
        public int IdServicioTurno
        {
            get => IdServicio;
            set => IdServicio = value;
        }
        public int NroHistorialClinicoTurno
        {
            get => NroHistialClinico;
            set => NroHistialClinico = value;
        }
    }
}
