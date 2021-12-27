using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Diagnostico
    {
        private int idDiagno;
        private string Nombre;



        public Diagnostico(int iddiag, string nombre)
        {
            idDiagno = iddiag;
            Nombre = nombre;
        }
        public Diagnostico()
        {

        }

        public int IdDiagnostico
        {
            get => idDiagno;
            set => idDiagno = value;
        }

        public string Nombrediagnostico
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
}
