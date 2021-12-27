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
    public partial class Pantalla_AgregarDiagosticoXConsulta : Form
    {
        private List<Diagnostico> listaDiag;


        public Pantalla_AgregarDiagosticoXConsulta(List<Diagnostico> lista)
        {
            this.listaDiag = lista;
            InitializeComponent();
        }

        private void Pantalla_AgregarDiagosticoXConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdDiag.Text != "")
                {
                    DataTable tablaResultadoDiag = AD_ObtenerDatos.ObtenerDiagnosticoParaTransaccion(int.Parse(txtIdDiag.Text));
                    if (tablaResultadoDiag.Rows.Count > 0)
                    {
                        txtIdDiag.Text = tablaResultadoDiag.Rows[0][0].ToString();
                        txtNombreDiag.Text = tablaResultadoDiag.Rows[0][1].ToString();

                    }
                    else
                    {
                        MessageBox.Show("Diagnostico inexistente");
                        txtIdDiag.Focus();
                        txtNombreDiag.Text = " ";

                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un ID para la busqueda");
                    txtIdDiag.Focus();
                    txtIdDiag.Text = "";
                    txtNombreDiag.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }

        private void btnAgregarDoag_Click(object sender, EventArgs e)
        {
            if (txtIdDiag.Text == "" || txtNombreDiag.Text == "")
            {
                MessageBox.Show("Hay campos vacios, no es posible agregar diagnostico");
            }
            else
            {
                grillaDiagnostico.Rows.Add(txtIdDiag.Text, txtNombreDiag.Text);
                Diagnostico nuevo = new Diagnostico(int.Parse(txtIdDiag.Text), txtNombreDiag.Text);
                listaDiag.Add(nuevo);
                txtNombreDiag.Text = "";
                txtIdDiag.Text = "";
            }
        }

        private void btnGuardarDig_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
    }
}