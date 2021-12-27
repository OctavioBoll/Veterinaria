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
    public partial class AgregarConsultas : Form
    {
        private int NroConsulSeleccionado;
        private Consulta ConsultaSeleccionada = new Consulta();
        public AgregarConsultas()
        {
            InitializeComponent();
        }

        private void AgregarConsultas_Load(object sender, EventArgs e)
        {
            ObtenerUltimoNroConsulta();
            CargarComboTipoDocumento();
            CargarComboTipoMotivo();
        }

        private void ObtenerUltimoNroConsulta()
        {
            int nroConsulta = AD_ObtenerDatos.ObtenerUltimoNroConsulta();
            lblNroConsulta.Text = (nroConsulta + 1).ToString();
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

        //private void dgvConsultas_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int indice = e.RowIndex;
        //    if (indice >= 0)
        //    {
        //        DataGridViewRow filaSeleccionada = dgvConsultas.Rows[indice];
        //        NroConsulSeleccionado = (int)filaSeleccionada.Cells["nro_consulta"].Value;
        //        ConsultaSeleccionada.NroConsulta = NroConsulSeleccionado;
        //        ConsultaSeleccionada.NroHistClinicaConsulta = (int)filaSeleccionada.Cells["nro_hist_clinica"].Value;
        //        ConsultaSeleccionada.TipoDocEmpleadoConsulta = (int)filaSeleccionada.Cells["tipo_doc_empleado"].Value;
        //        ConsultaSeleccionada.NroDocEmpleadoConsulta = (string)filaSeleccionada.Cells["nro_doc_empleado"].Value;
        //        ConsultaSeleccionada.FechaConsulta = (DateTime)filaSeleccionada.Cells["fecha"].Value;
        //        ConsultaSeleccionada.HoraConsulta = (TimeSpan)filaSeleccionada.Cells["hora"].Value;
        //        ConsultaSeleccionada.IdMotivoConsulta = (int)filaSeleccionada.Cells["id_motivo"].Value;

        //    }
        //}




        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnAltaConsulta_Click(object sender, EventArgs e)
        {
            List<Medicamentos> lista = new List<Medicamentos>();
            Pantalla_AgregarMedicamentoXConsulta ventanaMedXConsulta = new Pantalla_AgregarMedicamentoXConsulta(lista);

            DialogResult resultado = ventanaMedXConsulta.ShowDialog();
            ventanaMedXConsulta.Dispose();
            if (DialogResult.OK == resultado)
            {
                foreach (Medicamentos med in lista)
                {
                    grillaMedicamento.Rows.Add(med.CodigoMedicamento.ToString(), med.DescripcionMedicamento, med.PrecioMedicamento.ToString());
                }
            }
        }

        private void btnAgregarVac_Click(object sender, EventArgs e)
        {
            List<Vacunas> Lvac = new List<Vacunas>();


            Pantalla_AgregarVacunasAConsulta ventanaVacXConsulta = new Pantalla_AgregarVacunasAConsulta(Lvac);
            DialogResult result = ventanaVacXConsulta.ShowDialog();
            ventanaVacXConsulta.Dispose();

            if (DialogResult.OK == result)
            {
                foreach (Vacunas v in Lvac)
                {
                    dgrVacunas.Rows.Add(v.CodigoVacuna, v.NombreVacuna, v.PrecioVacuna);
                }
            }
        }

        private void btnAgregarDiagnostico_Click(object sender, EventArgs e)
        {
            List<Diagnostico> lista = new List<Diagnostico>();
            Pantalla_AgregarDiagosticoXConsulta ventanaDiagXConsulta = new Pantalla_AgregarDiagosticoXConsulta(lista);

            DialogResult resultado = ventanaDiagXConsulta.ShowDialog();
            ventanaDiagXConsulta.Dispose();
            if (DialogResult.OK == resultado)
            {
                foreach (Diagnostico diag in lista)
                {
                    grillaDiagnostico.Rows.Add(diag.IdDiagnostico.ToString(), diag.Nombrediagnostico);
                }
            }
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            List<Medicamentos> lista = new List<Medicamentos>();
            Pantalla_AgregarMedicamentoXConsulta ventanaMedXConsulta = new Pantalla_AgregarMedicamentoXConsulta(lista);

            DialogResult resultado = ventanaMedXConsulta.ShowDialog();
            ventanaMedXConsulta.Dispose();
            if (DialogResult.OK == resultado)
            {
                foreach (Medicamentos med in lista)
                {
                    grillaMedicamento.Rows.Add(med.CodigoMedicamento.ToString(), med.DescripcionMedicamento, med.PrecioMedicamento.ToString());
                }
            }

        }

        private Consulta obtenerConsulta()
        {
            Consulta consulta = new Consulta();
            consulta.NroConsulta = int.Parse(lblNroConsulta.Text);
            consulta.NroHistClinicaConsulta = int.Parse(mskNroHistClinica.Text);
            consulta.TipoDocEmpleadoConsulta = (int)cmbTipoDoc.SelectedValue;
            consulta.NroDocEmpleadoConsulta = txtNroDoc.Text;
            consulta.FechaConsulta = dtpFecha.Value;
            consulta.HoraConsulta = TimeSpan.Parse(mskHora.Text);
            consulta.IdMotivoConsulta = (int)cmbMotivo.SelectedValue;
            return consulta;
        }

        private bool validarCampos()
        {
            bool resultado = false;
            if (mskNroHistClinica.Text.Trim().Equals(""))
            {
                MessageBox.Show("Llene el en campo de Nro Hist. Clinica");
                mskNroHistClinica.Focus();
                return resultado;
            }
            if ((int)cmbTipoDoc.SelectedIndex == -1 || txtNroDoc.Text.Trim().Equals(""))
            {
                MessageBox.Show("Llene los campos de empleado");
                cmbTipoDoc.Focus();
                return resultado;
            }
            try
            {
                DateTime fecha = DateTime.Parse(mskHora.Text.Trim());
                if (mskHora.Text.Trim().Equals(":"))
                {
                    MessageBox.Show("Ingrese la hora de la consulta");
                    mskHora.Focus();
                    return resultado;
                }
            }
            catch
            {
                MessageBox.Show("La hora ingresada posee un formato incorrecto");
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



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                if (lblValidarHistClinico.Text != "Correcto") { MessageBox.Show("Debe ingresar un número de hsitoria cílínica existente"); }
                else if (lblValidarEmpleado.Text != "Correcto") { MessageBox.Show("Debe ingresar un empleado existente"); }
                else
                {
                    DateTime fecha = dtpFecha.Value;

                    int buscarConsu = int.Parse(lblNroConsulta.Text);
                    Consulta c = obtenerConsulta();

                    List<int> listaVacunas = new List<int>();
                    List<int> listaDiagnostico = new List<int>();
                    List<int> listaMedicamento = new List<int>();

                    for (int i = 0; i < dgrVacunas.Rows.Count; i++)
                    {
                        listaVacunas.Add(int.Parse(dgrVacunas.Rows[i].Cells[0].Value.ToString())); //celda 0 tiene el id.
                    }

                    for (int i = 0; i < grillaDiagnostico.Rows.Count; i++)
                    {
                        listaDiagnostico.Add(int.Parse(grillaDiagnostico.Rows[i].Cells[0].Value.ToString()));
                    }

                    for (int i = 0; i < grillaMedicamento.Rows.Count; i++)
                    {
                        listaMedicamento.Add(int.Parse(grillaMedicamento.Rows[i].Cells[0].Value.ToString()));
                    }

                    try
                    {

                        bool resultado = AD_AgregarDatosBD.AgregarConsulta(c, listaVacunas, listaDiagnostico, listaMedicamento);


                        if (resultado)
                        {
                            MessageBox.Show("Consulta dada de alta con exito");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Error al dar alta nueva consulta");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PantallaPrincipal1 ventanaprincipal = new PantallaPrincipal1();
            ventanaprincipal.Show();
            this.Hide();
        }

        private void btnValidarNroHist_Click(object sender, EventArgs e)
        {
            bool resultado = AD_ObtenerDatos.ValidarNorHistClinica(int.Parse(mskNroHistClinica.Text));
            if (!resultado)
            {
                MessageBox.Show("No hay mascotas registradas con ese número de historia Clinica");
                mskNroHistClinica.Text = "";
                mskNroHistClinica.Focus();
            }
            else
            {
                MessageBox.Show("Mascota Existente");
            }
        }

        private void btnValidarEmpleado_Click(object sender, EventArgs e)
        {
            Empleados empleado = AD_ObtenerDatos.ObtenerEmpleado(Convert.ToInt32(cmbTipoDoc.SelectedValue), txtNroDoc.Text);
            bool resultado = false;
            if (empleado == null) { resultado = true; }
            if (resultado)
            {
                MessageBox.Show("No hay empleados registradas con ese número de documento");
                txtNroDoc.Text = "";
                cmbTipoDoc.SelectedIndex = -1;
                txtNroDoc.Focus();
            }
            else
            {
                MessageBox.Show("Empleado Existente");
            }
        }

        private void btnValidarNroHist_Click_1(object sender, EventArgs e)
        {
            lblValidarHistClinico.Text = "";
            bool resultado = false;
            if (mskNroHistClinica.Text == "") { MessageBox.Show("Complete los datos antes de validar"); }
            else
            {
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
        }

        private void btnValidarEmpleado_Click_1(object sender, EventArgs e)
        {
            lblEmpleado.Text = "";
            lblValidarEmpleado.Text = "";
            bool resultado = false;
            if (txtNroDoc.Text == "" || cmbTipoDoc.SelectedIndex == -1) { MessageBox.Show("Complete los datos antes de validar"); }
            else
            {
                try
                {
                    Empleados empleado = AD_ObtenerDatos.ObtenerEmpleado((int)cmbTipoDoc.SelectedValue, txtNroDoc.Text);
                    if (empleado.Apellido != null)
                    {
                        resultado = true;
                        lblEmpleado.Text = empleado.Apellido + ", " + empleado.Nombre;
                    }
                }
                catch (Exception)
                {
                    resultado = false;
                }
                if (resultado)
                {
                    lblValidarEmpleado.Text = "Correcto";
                }
                else
                {
                    lblValidarEmpleado.Text = "No existente";
                }
            }
        }
    }
}
