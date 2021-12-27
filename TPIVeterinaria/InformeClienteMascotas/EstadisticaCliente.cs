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

namespace TPIVeterinaria.InformeClienteMascotas
{
    public partial class EstadisticaCliente : Form
    {
        public EstadisticaCliente()
        {
            InitializeComponent();
        }

        private void EstadisticaCliente_Load(object sender, EventArgs e)
        {
            this.rptEstadisticaCliente.RefreshReport();
        }

        private void rptEstadisticaCliente_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Informes.CargarTablaMascotas();

            ReportDataSource ds = new ReportDataSource("EstadisticaCliente", tabla);
            rptEstadisticaCliente.LocalReport.DataSources.Clear();
            rptEstadisticaCliente.LocalReport.DataSources.Add(ds);
            rptEstadisticaCliente.LocalReport.Refresh();
        }
    }
}
