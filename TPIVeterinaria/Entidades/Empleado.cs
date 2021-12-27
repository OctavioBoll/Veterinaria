using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Empleados
    {
        private int tipoDocumento;
        private string nroDocumento;
        private string apellido;
        private string nombre;
        private string celular;
        private int cargo;
        private DateTime fechaIngreso;
        private DateTime fechaFinLaboral;
        private string calle;
        private string nroCalle;
        private string codigoPostal;
        private string motivo;
        //private string contraseña;
        private int usuario;
        private int idEmpleado;

        public void Empleado()
        {

        }
        public int TipoDocumento
        {
            get => tipoDocumento;
            set => tipoDocumento = value;
        }
        public int ID
        {
            get => idEmpleado;
            set => idEmpleado = value;
        }
        public string NroDocumento
        {
            get => nroDocumento;
            set => nroDocumento = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Celular
        {
            get => celular;
            set => celular = value;
        }
        public int Cargo
        {
            get => cargo;
            set => cargo = value;
        }
        public DateTime FechaIngreso
        {
            get => fechaIngreso;
            set => fechaIngreso = value;
        }
        public DateTime FechaFinLaboral
        {
            get => fechaFinLaboral;
            set => fechaFinLaboral = value;
        }
        public string Calle
        {
            get => calle;
            set => calle = value;
        }
        public string NroCalle
        {
            get => nroCalle;
            set => nroCalle = value;
        }
        public string CodPostal
        {
            get => codigoPostal;
            set => codigoPostal = value;
        }
        public string Motivo
        {
            get => motivo;
            set => motivo = value;
        }
        public int Usuario { get => usuario; set => usuario = value; }
        //public string Usuario
        //{
        //    get => usuario;
        //    set => usuario = value;
        //}
        //public string Contraseña
        //{
        //    get => contraseña;
        //    set => contraseña = value;
        //}

    }

}
