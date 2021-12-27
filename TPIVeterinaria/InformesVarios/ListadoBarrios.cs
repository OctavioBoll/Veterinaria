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
    public partial class ListadoBarrios : Form
    {
        public ListadoBarrios()
        {
            InitializeComponent();
        }

        private void ListadoBarrios_Load(object sender, EventArgs e)
        {

            this.rpvBarrios.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rpvBarrios_Load(txtNombre.Text);
            lblinformarActualizar.Visible = true;
        }

        private void rpvBarrios_Load(string nombre)
        {
            DataTable tabla = new DataTable();
            tabla = AD_ObtenerDatos.obtenerDiagnosticoXNombre(txtNombre.Text);

            ReportDataSource ds = new ReportDataSource("DatosBarrios", tabla);

            rpvBarrios.LocalReport.DataSources.Clear();
            rpvBarrios.LocalReport.DataSources.Add(ds);
            rpvBarrios.LocalReport.Refresh();
        }

        private void rpvBarrios_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_CargarGrillas.CargarGrillaBarrio();

            ReportDataSource ds = new ReportDataSource("DatosBarrios", tabla);

            rpvBarrios.LocalReport.DataSources.Clear();
            rpvBarrios.LocalReport.DataSources.Add(ds);
            rpvBarrios.LocalReport.Refresh();
        }
    }
}
