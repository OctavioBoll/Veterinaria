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
    public partial class PantallaPrincipal3 : Form
    {
        public PantallaPrincipal3()
        {
            InitializeComponent();
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
    }
}
