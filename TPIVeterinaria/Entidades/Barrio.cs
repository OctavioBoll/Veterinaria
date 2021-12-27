using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Barrio
    {
        private int Codigo;
        private string Nombre;


        public Barrio(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }
        public Barrio()
        {

        }

        public int CodigoPostal
        {
            get => Codigo;
            set => Codigo = value;
        }
        public string NombreBarrio
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
