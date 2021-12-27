using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Servicio
    {
        string nombre;
        float precio;
        int id_servicio;

        public void Servicios()
        {

        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public float Precio
        {
            get => precio;
            set => precio = value;
        }
        public int ID
        {
            get => id_servicio;
            set => id_servicio = value;
        }

    }

}
