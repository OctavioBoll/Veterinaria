using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Proveedores
    {
        private string Nombre;
        private int CodigoProveedor;


        public Proveedores(string nombre, int codigoprov)
        {
            Nombre = nombre;
            CodigoProveedor = codigoprov;
        }
        public Proveedores()
        {

        }

        public string NombreProveedor
        {
            get => Nombre;
            set => Nombre = value;
        }
        public int CodigoDelProveedor
        {
            get => CodigoProveedor;
            set => CodigoProveedor = value;
        }
    }
}
