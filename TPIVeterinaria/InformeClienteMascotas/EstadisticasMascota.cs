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
    public partial class EstadisticasMascota : Form
    {
        public EstadisticasMascota()
        {
            InitializeComponent();
        }

        private void EstadisticasMascota_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Informes.CargarTablaMascotasXRaza();

            ReportDataSource ds = new ReportDataSource("DataMascotaRaza", tabla);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.Refresh();
        }

        private void btnBuscarRaza_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Informes.CargarTablaMascotasXEspecies();

            ReportDataSource ds = new ReportDataSource("DataMascotasXEspecie", tabla);
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(ds);
            reportViewer2.LocalReport.Refresh();
        }

        private void btnBuscarEspecie_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Informes.CargarTablaMascotasXSexo();

            ReportDataSource ds = new ReportDataSource("DataMascotasXSexo", tabla);
            reportViewer3.LocalReport.DataSources.Clear();
            reportViewer3.LocalReport.DataSources.Add(ds);
            reportViewer3.LocalReport.Refresh();
        }

        private void btnBuscarSexo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }
    }
}
