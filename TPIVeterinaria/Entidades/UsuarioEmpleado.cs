using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class UsuarioEmpleado
    {
        private string NombreUsuario;
        private string PassUsuario;
        private int IdCargo;



        public UsuarioEmpleado(string nombre, string pass)
        {
            NombreEmpleado = nombre;
            PassUsuario = pass;
        }
        public UsuarioEmpleado()
        {

        }

        public string NombreEmpleado
        {
            get => NombreUsuario;
            set => NombreUsuario = value;
        }
        public string PasswordEmpleado
        {
            get => PassUsuario;
            set => PassUsuario = value;
        }
        public int ID
        {
            get => IdCargo;
            set => IdCargo = value;
        }
    }
}
