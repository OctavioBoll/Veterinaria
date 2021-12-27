using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPIVeterinaria.Entidades;
using TPIVeterinaria.Funcionalidades;

namespace TPIVeterinaria
{
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            CargarCombosTipoDocumentos();
            LimpiarCampos();
        }


        private void CargarCombosTipoDocumentos()
        {
            cmbTipoDocumento.DataSource = AD_CargarCombos.CargarComboGenerico("TIPOS_DOCUMENTOS");
            cmbTipoDocumento.DisplayMember = "nombre_tipo_documento";
            cmbTipoDocumento.ValueMember = "id_tipo_documento";
            cmbTipoDocumento.SelectedIndex = -1;
        }
        private void CargarCampos(Cliente p)//Cargar clientes buscados seleccionado en las cajas texto
        {
            txtNombre.Text = p.NombreClientes;
            txtApellido.Text = p.ApellidoCliente;
            txtMail.Text = p.MailCliente;
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNroDoc.Text = "";
            txtMail.Text = "";
            cmbTipoDocumento.SelectedIndex = -1;
        }

        private Cliente ObtenerDatosCliente()
        {
            Cliente p = new Cliente();
            p.NombreClientes = txtNombre.Text.Trim();
            p.ApellidoCliente = txtApellido.Text.Trim();
            p.TipoDocumento = (int)cmbTipoDocumento.SelectedValue;
            p.NumeroDocumento = txtNroDoc.Text.Trim();
            p.MailCliente = txtMail.Text.Trim();
            return p;
        }

        

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string buscarDoc = txtNroDoc.Text;
            int tipodoc = (int)cmbTipoDocumento.SelectedValue;
            Cliente p = AD_ObtenerDatos.ObtenerCliente(buscarDoc, tipodoc);
            CargarCampos(p);
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            Cliente p = ObtenerDatosCliente();
            bool resultado = AD_ActualizarDatos.ActualizarCliente(p);
            if (resultado)
            {
                MessageBox.Show("Datos Guardados con Exito");
                LimpiarCampos();
            }
            else 
            {
                MessageBox.Show("Error al Guardar los datos");
            }

        }
    }



}
