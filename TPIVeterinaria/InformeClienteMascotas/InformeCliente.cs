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
    public partial class InformeCliente : Form
    {
        public InformeCliente()
        {
            InitializeComponent();
        }

        private void InformeCliente_Load(object sender, EventArgs e)
        {
            this.rptClientes.RefreshReport();
        }

        private void rptClientes_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            tabla = AD_CargarGrillas.CargarGrillaCliente();

            ReportDataSource ds = new ReportDataSource("TablaClientes", tabla);

            rptClientes.LocalReport.DataSources.Clear();
            rptClientes.LocalReport.DataSources.Add(ds);
            rptClientes.LocalReport.Refresh();
        }

        private void rptClientes_Load(string nombre)
        {
            DataTable tabla = new DataTable();
            tabla = AD_Informes.BuscarClienteXNombre(nombre);

            ReportDataSource ds = new ReportDataSource("TablaClientes", tabla);

            rptClientes.LocalReport.DataSources.Clear();
            rptClientes.LocalReport.DataSources.Add(ds);
            rptClientes.LocalReport.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rptClientes_Load(txtNombre.Text);
            lblinformarActualizar.Visible = true;
        }
    }
}
