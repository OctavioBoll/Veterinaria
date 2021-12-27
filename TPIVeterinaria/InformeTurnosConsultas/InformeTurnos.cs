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

namespace TPIVeterinaria.InformeClienteMascotas
{
    public partial class InformeTurnos : Form
    {
        public InformeTurnos()
        {
            InitializeComponent();
        }

        private void InformeTurnos_Load(object sender, EventArgs e)
        {

            this.rptListadoTurnos.RefreshReport();
        }

        private void rptTurnos_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_CargarGrillas.CargarGrillaTurnos();

            ReportDataSource ds = new ReportDataSource("ReporteListadoTurnos", tabla);

            rptListadoTurnos.LocalReport.DataSources.Clear();
            rptListadoTurnos.LocalReport.DataSources.Add(ds);
            rptListadoTurnos.LocalReport.Refresh();


        }
    }
}
