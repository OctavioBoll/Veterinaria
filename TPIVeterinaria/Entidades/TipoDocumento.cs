using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class TipoDocumento
    {
        private int IdTipo;
        private string Nombre;


        public TipoDocumento(int idtipo, string nombre)
        {
            IdTipo = idtipo;
            Nombre = nombre;
        }
        public TipoDocumento()
        {

        }

        public int IdTipoDocumento
        {
            get => IdTipo;
            set => IdTipo = value;
        }
        public string NombreTipoDoc
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
