using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIVeterinaria
{
    public partial class PantallaPrincipal4 : Form
    {
        public PantallaPrincipal4()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            PantallaLogin ventanalogin = new PantallaLogin();
            ventanalogin.Show();
            this.Hide();
        }
    }
}
