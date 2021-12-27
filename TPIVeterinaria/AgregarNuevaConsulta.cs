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
    public partial class AgregarNuevaConsulta : Form
    {
        public AgregarNuevaConsulta()
        {
            InitializeComponent();
        }

        private void AgregarNuevaConsulta_Load(object sender, EventArgs e)
        {
            CargarComboTipoDocumento();
            CargarComboTipoMotivo();
            
        }
        private void CargarComboTipoDocumento()
        {
            cmbTipoDoc.DataSource = AD_CargarCombos.CargarComboGenerico("TIPOS_DOCUMENTOS");
            cmbTipoDoc.DisplayMember = "nombre_tipo_documento";
            cmbTipoDoc.ValueMember = "id_tipo_documento";
            cmbTipoDoc.SelectedIndex = -1;
        }
        private void CargarComboTipoMotivo()
        {
            cmbMotivo.DataSource = AD_CargarCombos.CargarComboGenerico("MOTIVO");
            cmbMotivo.DisplayMember = "nombre";
            cmbMotivo.ValueMember = "id_motivo";
            cmbMotivo.SelectedIndex = -1;
        }




        private void btnValidarNroHist_Click(object sender, EventArgs e)
        {
            bool resultado = false;
            if (mskNroHistClinica.Text.Trim().Equals(""))
            {
                lblValidarHistClinico.Text = "";
                return;
            }
            try
            {
                resultado = AD_ObtenerDatos.ValidarNorHistClinica(int.Parse(mskNroHistClinica.Text));
            }
            catch (Exception)
            {
                resultado = false;
            }
            
            if (resultado)
            {
                lblValidarHistClinico.Text = "Correcto";
            }
            else
            {
                lblValidarHistClinico.Text = "No existente";
            }
        }

        private void btnValidarEmpleado_Click(object sender, EventArgs e)
        {
            lblNobreEmpleado.Text = "";
            bool resultado = false;
            try
            {
                Empleados empleado = AD_ObtenerDatos.ObtenerEmpleado((int)cmbTipoDoc.SelectedValue, txtNroDoc.Text);
                lblValidarEmpleado.Text = "Correcto";
                lblNobreEmpleado.Text = empleado.Apellido + ", " + empleado.Nombre;
                if (empleado == null) { resultado = true; }
            }
            catch (Exception)
            {
                if (resultado)
                {
                    lblValidarEmpleado.Text = "No existente";
                    lblNobreEmpleado.Text = "";
                }
                else { lblValidarEmpleado.Text = "Correcto"; }
            }
            
            
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgrenar_Click(object sender, EventArgs e)
        {
            bool resultado = ValidarCampos();
            if (resultado)
            {
                Consulta consulta = new Consulta();
                try
                {
                    consulta.HoraConsulta = TimeSpan.Parse(mskHora.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ingrese correctamente la hora, completando con ceros si es necesario");
                    return;
                }
                consulta.NroHistClinicaConsulta = int.Parse(mskNroHistClinica.Text.Trim());
                consulta.TipoDocEmpleadoConsulta = (int)cmbTipoDoc.SelectedValue;
                consulta.NroDocEmpleadoConsulta = txtNroDoc.Text.Trim();
                consulta.FechaConsulta = dtpFecha.Value.Date;
                
                consulta.IdMotivoConsulta = (int)cmbMotivo.SelectedValue;

                //bool resulInsert = AD_AgregarDatosBD.AgredarConsulta(consulta);
                //if (resulInsert)
                //{
                //    MessageBox.Show("La Consulta se agrego con exito");
                //    this.Hide();
                //}
                //else
                //{
                //    MessageBox.Show("No se pudo Agregar la Consulta\nValide los campos necesarios");
                //}
            }

        }
        private bool ValidarCampos()
        {
            bool resultado = false;
            if(mskNroHistClinica.Text.Trim().Equals(""))
            { 
                MessageBox.Show("Llene el en campo de Nro Hist. Clinica");
                mskNroHistClinica.Focus();
                return resultado;
            }
            if ((int)cmbTipoDoc.SelectedIndex == -1 || txtNroDoc.Text.Trim().Equals("")  )
            {
                MessageBox.Show("Llene los campos de empleado");
                cmbTipoDoc.Focus();
                return resultado;
            }
            
            if (mskHora.Text.Trim().Equals(":"))
            {
                MessageBox.Show("Ingrese la hora de la consulta");
                mskHora.Focus();
                return resultado;
            }
            if ((int)cmbMotivo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Motivo de Consulta");
                cmbTipoDoc.Focus();
                return resultado;
            }
            resultado = true;
            return resultado;
        }
    }
}
