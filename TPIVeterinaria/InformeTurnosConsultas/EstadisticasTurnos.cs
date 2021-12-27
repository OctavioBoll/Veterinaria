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
    public partial class EstadisticasTurnos : Form
    {
        public EstadisticasTurnos()
        {
            InitializeComponent();
        }

        private void EstadisticasTurnos_Load(object sender, EventArgs e)
        {

            this.rptEstadisticasTurnos.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Informes.CargarTablaTurnosXDia();

            ReportDataSource ds = new ReportDataSource("ReporteEstadisticasTurnos", tabla);

            rptEstadisticasTurnos.LocalReport.DataSources.Clear();
            rptEstadisticasTurnos.LocalReport.DataSources.Add(ds);
            rptEstadisticasTurnos.LocalReport.Refresh();

        }
    }
}
