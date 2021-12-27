using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Consulta
    {
        private int Nro;
        private int NroHistClinica;
        private int TipoDocEmpleado;
        private string NroDocEmpleado;
        private DateTime Fecha;
        private TimeSpan Hora;
        private int IdMotivo;

        public Consulta()
        {

        }

        public int NroConsulta
        {
            get => Nro;
            set => Nro = value;
        }
        public int NroHistClinicaConsulta
        {
            get => NroHistClinica;
            set => NroHistClinica = value;
        }
        public int TipoDocEmpleadoConsulta
        {
            get => TipoDocEmpleado;
            set => TipoDocEmpleado = value;
        }
        public string NroDocEmpleadoConsulta
        {
            get => NroDocEmpleado;
            set => NroDocEmpleado = value;
        }
        public DateTime FechaConsulta
        {
            get => Fecha;
            set => Fecha = value;
        }
        public TimeSpan HoraConsulta
        {
            get => Hora;
            set => Hora = value;
        }
        public int IdMotivoConsulta
        {
            get => IdMotivo;
            set => IdMotivo = value;
        }

    }
}
