﻿using System;
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
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            PantallaLogin ventana = new PantallaLogin();
            ventana.Show();

            btnLogin.Enabled = false;
        }
    }
}
