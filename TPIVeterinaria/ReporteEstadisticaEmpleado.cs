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

namespace TPIVeterinaria
{
    public partial class ReporteEstadisticaEmpleado : Form
    {
        public ReporteEstadisticaEmpleado()
        {
            InitializeComponent();
        }

        private void ReporteEstadisticaEmpleado_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_ObtenerDatos.ObtenerNroEmpleadosPorCargo();

            ReportDataSource ds = new ReportDataSource("DatosEstadisticosEmpleado", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);

            reportViewer1.LocalReport.Refresh();
        }
    }
}
