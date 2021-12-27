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

namespace TPIVeterinaria.InformeTurnosConsultas
{
    public partial class EstadisticasConsultas : Form
    {
        public EstadisticasConsultas()
        {
            InitializeComponent();
        }

        private void EstadisticasConsultas_Load(object sender, EventArgs e)
        {

            this.rptEstadisticasConsultas.RefreshReport();
        }

        private void rptEstadisticasConsultas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Informes.CargarTablaConsultasXDia();

            ReportDataSource ds = new ReportDataSource("ReporteEstadisticasConsultas", tabla);
            rptEstadisticasConsultas.LocalReport.DataSources.Clear();
            rptEstadisticasConsultas.LocalReport.DataSources.Add(ds);
            rptEstadisticasConsultas.LocalReport.Refresh();
            
        }
    }
}
