using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Especie
    {
        string nombre;
        int id_especie;

        public string Nombre
        {
            get => nombre;
            set => nombre = value;

        }
        public int ID
        {
            get => id_especie;
            set => id_especie = value;

        }
    }

}
