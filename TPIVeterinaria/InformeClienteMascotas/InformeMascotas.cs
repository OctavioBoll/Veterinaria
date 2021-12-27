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
    public partial class InformeMascotas : Form
    {
        public InformeMascotas()
        {
            InitializeComponent();
        }

        private void InformeMascotas_Load(object sender, EventArgs e)
        {
            this.rptMascotas.RefreshReport();
        }

        private void rptMascotas_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Informes.BuscarMascotas();

            ReportDataSource ds = new ReportDataSource("TablaMascotas", tabla);

            rptMascotas.LocalReport.DataSources.Clear();
            rptMascotas.LocalReport.DataSources.Add(ds);
            rptMascotas.LocalReport.Refresh();
        }

        private void rptMascotas_Load()
        {
            DataTable tabla = new DataTable();
            tabla = AD_Informes.BuscarMascotasXFechas(txtFechainicio.Text,txtFechaFin.Text);

            ReportDataSource ds = new ReportDataSource("TablaMascotas", tabla);

            rptMascotas.LocalReport.DataSources.Clear();
            rptMascotas.LocalReport.DataSources.Add(ds);
            rptMascotas.LocalReport.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rptMascotas_Load();
            lblinformar.Visible = true;

        }
    }
}
