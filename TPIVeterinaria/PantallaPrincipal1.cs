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
using TPIVeterinaria.InformeClienteMascotas;
using TPIVeterinaria.Informes_Estadisticas.InformeVarios;
using TPIVeterinaria.InformesVarios;
using TPIVeterinaria.InformeTurnosConsultas;

namespace TPIVeterinaria
{
    public partial class PantallaPrincipal1 : Form
    {
        public PantallaPrincipal1()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarClientes ventana = new AgregarClientes();
            ventana.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            PantallaLogin ventanalogin = new PantallaLogin();
            ventanalogin.Show();
            this.Hide();

        }

        private void btnEditClientes_Click(object sender, EventArgs e)
        {
            EditarCliente ventana = new EditarCliente();
            ventana.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            AgregarProveedor ventanaprov = new AgregarProveedor();
            ventanaprov.Show();
        }

        private void btnAgregarVacunas_Click(object sender, EventArgs e)
        {
            AgregarVacunas ventanavac = new AgregarVacunas();
            ventanavac.Show();
        }

        private void btnAgregarMedicamentos_Click(object sender, EventArgs e)
        {
            AgregarMedicamentos ventanamed = new AgregarMedicamentos();
            ventanamed.Show();
        }

        private void btnAgregarBarrio_Click(object sender, EventArgs e)
        {
            AgregarBarrios ventanabarr = new AgregarBarrios();
            ventanabarr.Show();
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            AgregarCargo ventacarg = new AgregarCargo();
            ventacarg.Show();
        }

        private void btnAgregarDiagnostico_Click(object sender, EventArgs e)
        {
            AgregarDiagnostico ventanadiag = new AgregarDiagnostico();
            ventanadiag.Show();
        }



        private void PantallaPrincipal1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarTipoDoc_Click(object sender, EventArgs e)
        {
            AgregarTipoDocumento ventanatipo = new AgregarTipoDocumento();
            ventanatipo.Show();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleado ventanaemp = new AgregarEmpleado();
            ventanaemp.Show();
        }

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            AgregarServicio ventanaser = new AgregarServicio();
            ventanaser.Show();
        }

        private void btnAgregarEspecie_Click(object sender, EventArgs e)
        {
            AgregarEspecie ventanaesp = new AgregarEspecie();
            ventanaesp.Show();
        }

        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            AgregarConsultas ventanacons = new AgregarConsultas();
            ventanacons.Show();
        }

        private void btnAgregarMotivo_Click(object sender, EventArgs e)
        {
            AgregarMotivo ventanamot = new AgregarMotivo();
            ventanamot.Show();
        }

        private void btnAgregarRaza_Click(object sender, EventArgs e)
        {
            AgregarRaza ventanaraza = new AgregarRaza();
            ventanaraza.Show();
        }

        private void btnAgregarTurno_Click(object sender, EventArgs e)
        {
            AgregarTurno ventanarutno = new AgregarTurno();
            ventanarutno.Show();
        }

        private void listadoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeCliente ventana = new InformeCliente();
            ventana.ShowDialog();
        }

        private void listadoMascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeMascotas ventana = new InformeMascotas();
            ventana.ShowDialog();
        }

        private void estadisticaTipoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticaCliente ventana = new EstadisticaCliente();
            ventana.ShowDialog();
        }

        private void estadisticaMascotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticasMascota ventana = new EstadisticasMascota();
            ventana.ShowDialog();
        }

        private void listadoDiagnosticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoDiagnosticos ventana = new ListadoDiagnosticos();
            ventana.ShowDialog();
        }

        private void listadoBarriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoBarrios ventana = new ListadoBarrios();
            ventana.ShowDialog();
        }

        private void estadisticaBarriosDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticaBarrio ventana = new EstadisticaBarrio();
            ventana.ShowDialog();
        }

        private void estadisticaCargosEstablecidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticaCargos ventana = new EstadisticaCargos();
            ventana.ShowDialog();
        }

        private void listadoDeTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeTurnos ventana = new InformeTurnos();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void listadoConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeConsultas ventana = new InformeConsultas();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void estadisticasTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticasTurnos ventana = new EstadisticasTurnos();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void estadisticasConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticasConsultas ventana = new EstadisticasConsultas();
            ventana.ShowDialog();
            ventana.Dispose();
        }

        private void ingresadosEnJulioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteListadoEmpleados ventana = new ReporteListadoEmpleados();
            ventana.ShowDialog();
        }

        private void cantidadDeEmpleadosPorCargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEstadisticaEmpleado ventana = new ReporteEstadisticaEmpleado();
            ventana.ShowDialog();
        }
    }
}
