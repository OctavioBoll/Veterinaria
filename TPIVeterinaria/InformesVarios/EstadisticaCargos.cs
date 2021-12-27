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

namespace TPIVeterinaria.InformesVarios
{
    public partial class EstadisticaCargos : Form
    {
        public EstadisticaCargos()
        {
            InitializeComponent();
        }

        private void EstadisticaCargos_Load(object sender, EventArgs e)
        {

            this.rptCargosEmpleados.RefreshReport();
        }

        private void rptCargosEmpleados_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Informes.CargarTablaCantidadCargos();

            ReportDataSource ds = new ReportDataSource("DatosCantidadCargos", tabla);
            rptCargosEmpleados.LocalReport.DataSources.Clear();
            rptCargosEmpleados.LocalReport.DataSources.Add(ds);
            rptCargosEmpleados.LocalReport.Refresh();
        }
    }
}
