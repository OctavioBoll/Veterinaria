using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPIVeterinaria.Entidades;
using TPIVeterinaria.Funcionalidades;

namespace TPIVeterinaria
{
    public partial class PantallaLogin : Form
    {
        public PantallaLogin()
        {
            InitializeComponent();
        }


        private void PantallaLogin_Load(object sender, EventArgs e)
        {
            CargarCombosCargo();
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {          
            if (txtUsuario.Text.Equals(""))
            {
                DialogResult = MessageBox.Show("Ingrese Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtContraseña.Text.Equals(""))
            {
                DialogResult = MessageBox.Show("Ingrese Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (cmbCargo.SelectedValue == null)
            {
                DialogResult = MessageBox.Show("Ingrese un Cargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int cargo = (int)cmbCargo.SelectedValue;
                string nombreDeUsuario = txtUsuario.Text;
                string password = txtContraseña.Text;
                bool resultado = false;
                try
                {
                    resultado = AD_ObtenerDatos.ValidarUsuario(nombreDeUsuario, password, cargo);
                    
                    if (resultado == true)
                    {
                        if(cargo == 1)
                        {
                            UsuarioEmpleado usu = new UsuarioEmpleado(nombreDeUsuario, password);
                            PantallaPrincipal2 ventana = new PantallaPrincipal2();
                            ventana.Show();
                            this.Hide();
                        }
                        else if (cargo == 2)
                        {
                            UsuarioEmpleado usu = new UsuarioEmpleado(nombreDeUsuario, password);
                            PantallaPrincipal3 ventana = new PantallaPrincipal3();
                            ventana.Show();
                            this.Hide();
                        }
                        else if (cargo == 3)
                        {
                            UsuarioEmpleado usu = new UsuarioEmpleado(nombreDeUsuario, password);
                            PantallaPrincipal4 ventana = new PantallaPrincipal4();
                            ventana.Show();
                            this.Hide();
                        }
                        else if (cargo == 4)
                        {
                            UsuarioEmpleado usu = new UsuarioEmpleado(nombreDeUsuario, password);
                            PantallaPrincipal1 ventana = new PantallaPrincipal1();
                            ventana.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        DialogResult = MessageBox.Show("Ingrese Correctamente los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Usuario Inexistente");
                }
            }
        }
        private void CargarCombosCargo()
        {
            try
            {
                cmbCargo.DataSource = AD_CargarCombos.CargarComboGenerico("CARGOS");
                cmbCargo.DisplayMember = "nombre";
                cmbCargo.ValueMember = "id_cargo";
                cmbCargo.SelectedIndex = -1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            cmbCargo.SelectedIndex = -1;
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                epError.SetError(txtUsuario,"Ingrese un Usuario");
                txtUsuario.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtContraseña_Validated(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() == "")
            {
                epError.SetError(txtContraseña, "Ingrese un Contraseña");
                txtContraseña.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
