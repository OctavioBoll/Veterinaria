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
    public partial class ReporteListadoEmpleados : Form
    {
        public ReporteListadoEmpleados()
        {
            InitializeComponent();
        }

        private void ReporteListadoEmpleados_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'veterinariaDataSet.EMPLEADOS' Puede moverla o quitarla según sea necesario.
            //this.EMPLEADOSTableAdapter.Fill(this.veterinariaDataSet.EMPLEADOS);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_ObtenerDatos.ObtenerEmpleadosIngresadosEnJulio();

            ReportDataSource ds = new ReportDataSource("DatosEmpleados", tabla);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);

            reportViewer1.LocalReport.Refresh();
        }
    }
}
