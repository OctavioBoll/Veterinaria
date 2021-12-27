using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPIVeterinaria.Funcionalidades;

namespace TPIVeterinaria.Informes_Estadisticas.InformeVarios
{
    public partial class ListadoDiagnosticos : Form
    {
        public ListadoDiagnosticos()
        {
            InitializeComponent();
        }

        private void Informe_Load(object sender, EventArgs e)
        {

            this.rptDiagnosticos.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rptDiagnosticos_Load(txtNombre.Text);
            lblinformarActualizar.Visible = true;
        }

        private void rptDiagnosticos_Load(string nombre)
        {
            DataTable tabla = new DataTable();
            tabla = AD_ObtenerDatos.obtenerDiagnosticoXNombre(txtNombre.Text);

            ReportDataSource ds = new ReportDataSource("DatosDiagnosticos", tabla);

            rptDiagnosticos.LocalReport.DataSources.Clear();
            rptDiagnosticos.LocalReport.DataSources.Add(ds);
            rptDiagnosticos.LocalReport.Refresh();
        }

        private void rptDiagnosticos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_CargarGrillas.CargarGrillaDiagnostico();

            ReportDataSource ds = new ReportDataSource("DatosDiagnosticos", tabla);

            rptDiagnosticos.LocalReport.DataSources.Clear();
            rptDiagnosticos.LocalReport.DataSources.Add(ds);
            rptDiagnosticos.LocalReport.Refresh();

        }
    }
}
