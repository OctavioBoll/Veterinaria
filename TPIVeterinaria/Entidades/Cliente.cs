using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPIVeterinaria.Entidades
{
    public class Cliente
    {
        private string Nombre;
        private string Apellido;
        private int IdTipoDocumento;
        private string NroDocumento;
        private string Mail;

        public Cliente(string nombre,string apellido,int tipodoc,string nrodoc,string mail)
        {
            Nombre = nombre;
            Apellido = apellido;
            IdTipoDocumento = tipodoc;
            NroDocumento = nrodoc;
            Mail = mail;
        }
         public Cliente()
        {

        }

        public string NombreClientes
        {
            get => Nombre;
            set => Nombre = value;
        }
        public string ApellidoCliente
        {
            get => Apellido;
            set => Apellido = value;
        }
        public int TipoDocumento
        {
            get => IdTipoDocumento;
            set => IdTipoDocumento = value;
        }
        public string NumeroDocumento
        {
            get => NroDocumento;
            set => NroDocumento = value;
        }
        public string MailCliente
        {
            get => Mail;
            set => Mail = value;
        }
    }
}
