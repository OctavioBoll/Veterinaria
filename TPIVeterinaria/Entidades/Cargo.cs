using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Cargo
    {
        private int Idcarg;
        private string Nombre;


        public Cargo(int codigo, string nombre)
        {
            Idcarg = codigo;
            Nombre = nombre;
        }
        public Cargo()
        {

        }

        public int IdCargo
        {
            get => Idcarg;
            set => Idcarg = value;
        }
        public string NombreCargo
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}