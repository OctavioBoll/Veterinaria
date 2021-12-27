using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using TPIVeterinaria.Funcionalidades;
using TPIVeterinaria.InformeClienteMascotas;

namespace TPIVeterinaria.InformeTurnosConsultas
{
    public partial class InformeConsultas : Form
    {
        public InformeConsultas()
        {
            InitializeComponent();
        }

        private void InformeConsultas_Load(object sender, EventArgs e)
        {

            this.rptListadoConsultas.RefreshReport();
        }

        private void rptListadoConsultas_Load(object sender, EventArgs e)
        {
            DataTable tabla = AD_CargarGrillas.CargarGrillaConsultas();
            ReportDataSource ds = new ReportDataSource("ReporteListadoConsultas", tabla);

            rptListadoConsultas.LocalReport.DataSources.Clear();
            rptListadoConsultas.LocalReport.DataSources.Add(ds);
            rptListadoConsultas.LocalReport.Refresh();
        }
    }
}
