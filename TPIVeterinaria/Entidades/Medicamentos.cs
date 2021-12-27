using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Medicamentos
    {
        private int Codigo;
        private float Precio;
        private string Descripcion;
        private int CodigoProv;


        public Medicamentos(int codigo, float precio, string nombre, int idproveedor)
        {
            Codigo = codigo;
            Precio = precio;
            Descripcion = nombre;
            CodigoProv = idproveedor;
        }
        public Medicamentos()
        {

        }

        public int CodigoMedicamento
        {
            get => Codigo;
            set => Codigo = value;
        }
        public float PrecioMedicamento
        {
            get => Precio;
            set => Precio = value;
        }
        public string DescripcionMedicamento
        {
            get => Descripcion;
            set => Descripcion = value;
        }

        public int CodProveedor
        {
            get => CodigoProv;
            set => CodigoProv = value;
        }
    }
}
