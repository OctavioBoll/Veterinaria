using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Vacunas
    {
        private int Codigo;
        private float Precio;
        private string Nombre;


        public Vacunas(int codigo, float precio, string nombre)
        {
            Codigo = codigo;
            Precio = precio;
            Nombre = nombre;
        }
        public Vacunas()
        {

        }

        public int CodigoVacuna
        {
            get => Codigo;
            set => Codigo = value;
        }
        public float PrecioVacuna
        {
            get => Precio;
            set => Precio = value;
        }
        public string NombreVacuna
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
