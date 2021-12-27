using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIVeterinaria
{
    public partial class PantallaPrincipal2 : Form
    {
        public PantallaPrincipal2()
        {
            InitializeComponent();
        }

        private void PantallaPrincipal2_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarClientes ventana = new AgregarClientes();
            ventana.Show();
        }

        private void btnEditClientes_Click(object sender, EventArgs e)
        {
            EditarCliente ventana = new EditarCliente();
            ventana.Show();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            AgregarProveedor ventanaprov = new AgregarProveedor();
            ventanaprov.Show();
        }

        private void btnAgregarEspecie_Click(object sender, EventArgs e)
        {
            AgregarEspecie ventanaesp = new AgregarEspecie();
            ventanaesp.Show();
        }

        private void btnAgregarMedicamentos_Click(object sender, EventArgs e)
        {
            AgregarMedicamentos ventanamed = new AgregarMedicamentos();
            ventanamed.Show();
        }

        private void btnAgregarVacunas_Click(object sender, EventArgs e)
        {
            AgregarVacunas ventanavac = new AgregarVacunas();
            ventanavac.Show();
        }

        private void btnAgregarBarrio_Click(object sender, EventArgs e)
        {
            AgregarBarrios ventanabarr = new AgregarBarrios();
            ventanabarr.Show();
        }

        private void btnAgregarDiagnostico_Click(object sender, EventArgs e)
        {
            AgregarDiagnostico ventanadiag = new AgregarDiagnostico();
            ventanadiag.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            PantallaLogin ventanalogin = new PantallaLogin();
            ventanalogin.Show();
            this.Hide();
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            AgregarTurno ventanatur = new AgregarTurno();
            ventanatur.Show();
        }

        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            AgregarConsultas ventanacon = new AgregarConsultas();
            ventanacon.Show();
        }

        private void btnAgregarRaza_Click(object sender, EventArgs e)
        {
            AgregarRaza ventnaraza = new AgregarRaza();
            ventnaraza.Show();
        }
    }
}
