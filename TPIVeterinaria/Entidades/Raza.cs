using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Raza
    {
        private int Id;
        private string Nombre;
        private string Descripcion;

        public Raza()
        {

        }
        public int IdRaza
        {
            get => Id;
            set => Id = value;
        }
        public string NombreRaza
        {
            get => Nombre;
            set => Nombre = value;
        }
        public string DescripcionRaza
        {
            get => Descripcion;
            set => Descripcion = value;
        }
    }
}
