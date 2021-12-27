using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Mascotas
    {
        private int NroHisto;
        private string Nombre;
        private int IdRaza;
        private int IdEspecie;
        private DateTime FechaNac;
        private int PesoAprox;
        private int IdSexo;
        private string NroDoc;
        private int TipoDoc;
        private DateTime FechaIngreso;



        public Mascotas(int nrohisto,string nombre, int idraza, int idespecie, DateTime fechanacimiento, int pesoaprox, int idsexo, int tipodoc, string nrodoc, string mail, DateTime fechaingreso)
        {
            NroHisto = nrohisto;
            Nombre = nombre;
            IdRaza = idraza;
            IdEspecie = idespecie;
            FechaNac = fechanacimiento;
            PesoAprox = pesoaprox;
            IdSexo = idsexo;
            TipoDoc = tipodoc;
            NroDoc = nrodoc;
            FechaIngreso = fechaingreso;
        }
        public Mascotas()
        {

        }

        public int NroHistoMascota
        {
            get => NroHisto;
            set => NroHisto = value;
        }
        public string NombreMascota
        {
            get => Nombre;
            set => Nombre = value;
        }
        public int IdRazaMascota
        {
            get => IdRaza;
            set => IdRaza = value;
        }
        public int IdEspecieMascota
        {
            get => IdEspecie;
            set => IdEspecie = value;
        }
        public DateTime FechaNacMascota
        {
            get => FechaNac;
            set => FechaNac = value;
        }
        public int PesoAproxMascota
        {
            get => PesoAprox;
            set => PesoAprox = value;
        }
        public int IdSexoMascota
        {
            get => IdSexo;
            set => IdSexo = value;
        }
        public int TipoDocMascota
        {
            get => TipoDoc;
            set => TipoDoc = value;
        }
         public string NroDocMascota
        {
            get => NroDoc;
            set => NroDoc = value;
        }
         public DateTime FechaIngresoMascota
        {
            get => FechaIngreso;
            set => FechaIngreso = value;
        }
    }
}
