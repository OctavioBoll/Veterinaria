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
    public partial class EstadisticaBarrio : Form
    {
        public EstadisticaBarrio()
        {
            InitializeComponent();
        }

        private void EstadisticaBarrio_Load(object sender, EventArgs e)
        {

            this.rptEstadisticaEmpXBarrio.RefreshReport();
        }

        private void rptEstadisticaClientXBarrio_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Informes.CargarTablaClienteXBarrio();

            ReportDataSource ds = new ReportDataSource("DatosCantidadClientesxBarrio", tabla);
            rptEstadisticaEmpXBarrio.LocalReport.DataSources.Clear();
            rptEstadisticaEmpXBarrio.LocalReport.DataSources.Add(ds);
            rptEstadisticaEmpXBarrio.LocalReport.Refresh();
        }
    }
}
