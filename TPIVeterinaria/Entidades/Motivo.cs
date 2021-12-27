using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Motivo
    {
        private int Id;
        private string Nombre;
        private string Descripcion;

        public Motivo()
        {

        }

        public int IdMotivo
        {
            get => Id;
            set => Id = value;
        }
        public string NombreMotivo
        {
            get => Nombre;
            set => Nombre = value;
        }
        public string DescripcionMotivo
        {

            get => Descripcion;
            set => Descripcion = value;
        }
    }
}
