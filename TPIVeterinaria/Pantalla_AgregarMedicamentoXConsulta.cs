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
    public partial class Pantalla_AgregarMedicamentoXConsulta : Form
    {
        private List<Medicamentos> lista = new List<Medicamentos>();

        public Pantalla_AgregarMedicamentoXConsulta(List<Medicamentos> lista)
        {
            this.lista = lista;
            InitializeComponent();
        }

        private void Pantalla_AgregarMedicamentoXConsulta_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarCod_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultadoDiag = AD_ObtenerDatos.ObtenerMedicamentoPorDescripcion(txtNombreMed.Text);
                if (tablaResultadoDiag.Rows.Count > 0)
                {
                    txtCodMed.Text = tablaResultadoDiag.Rows[0][0].ToString();
                    txtPrecio.Text = tablaResultadoDiag.Rows[0][1].ToString();
                    txtNombreMed.Text = tablaResultadoDiag.Rows[0][2].ToString();
                    txtNroProv.Text = tablaResultadoDiag.Rows[0][3].ToString();
                }
                else
                {
                    MessageBox.Show("Medicamento inexistente");
                    txtNombreMed.Focus();
                    txtNombreMed.Text = " ";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void btnAgregarMed_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                grillamedicamento.Rows.Add(txtCodMed.Text, txtPrecio.Text, txtNombreMed.Text, txtNroProv.Text, txtCant.Text);
                Medicamentos nuevo = new Medicamentos();
                nuevo.CodigoMedicamento = int.Parse(txtCodMed.Text);
                nuevo.PrecioMedicamento = int.Parse(txtPrecio.Text);
                nuevo.DescripcionMedicamento = txtNombreMed.Text;
                nuevo.CodProveedor = int.Parse(txtNroProv.Text);
                int cantidad;
                try { cantidad = int.Parse(txtCant.Text.Trim()); }
                catch { cantidad = 1; }
                for (int i = 0; i < cantidad; i++)
                {
                    lista.Add(nuevo);
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios, no es posible agregar medicamento");
            }
        }

        private bool validarCampos()
        {
            bool resultado = true;
            if (txtPrecio.Text == "" || txtNroProv.Text == "" || txtNombreMed.Text == "" || txtCodMed.Text == "")
            {
                resultado = false;
            }
            return resultado;
        }

        private void btnGuardarMed_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
