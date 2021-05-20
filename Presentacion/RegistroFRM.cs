using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Actores;
using ReglasNegocio;

namespace Presentacion
{
    public partial class RegistroFRM : Form
    {
        public RegistroFRM()
        {
            InitializeComponent();
        }

       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Hide();
            //Inicio inicio = new Inicio();
            //inicio.Show();
        }

        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistroFRM_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarRegistro_Click_1(object sender, EventArgs e)
        {
            if (chkUser.Checked == true)
            {
                GestorUsuarios GestorU = new GestorUsuarios();
                Usuarios usuario = new Usuarios();
                usuario.contraseña = txtContraseña.Text;
                usuario.nombre = txtNom.Text;
                usuario.correo = txtCorreo.Text;


                if (GestorU.IsEmpty(usuario) == false)
                {

                    MessageBox.Show("Debes llenar todos los campos para poder registrarte");
                    txtContraseña.Clear();
                    txtNom.Clear();
                    txtCorreo.Clear();



                }
                else
                {
                    if (GestorU.Registrar(usuario))
                    {
                        MessageBox.Show("Te has registrado correctamente \n ¡Bienvenido!");
                        this.Hide();
                        VisualizacionVehiculoFRM inicio = new VisualizacionVehiculoFRM();
                        inicio.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya existe");
                        txtContraseña.Clear();
                        txtNom.Clear();
                        txtCorreo.Clear();

                    }
                }
            }
            else { 
            //if (chkAdmin.Checked = true)
            //{
                txtEmp.Enabled = true;
                GestorAdministradores GestorAdm = new GestorAdministradores();
                Administradores administradores = new Administradores();
                administradores.contraseña = txtContraseña.Text;
                administradores.nombre = txtNom.Text;
                administradores.empresa = txtEmp.Text;
                administradores.correo = txtCorreo.Text;


                if (GestorAdm.IsEmpty(administradores) == false)
                {

                    MessageBox.Show("Debes llenar todos los campos para poder registrarte");
                    txtContraseña.Clear();
                    txtNom.Clear();
                    txtCorreo.Clear();



                }
                else
                {
                    if (GestorAdm.Registrar(administradores))
                    {
                        MessageBox.Show("Te has registrado correctamente \n ¡Bienvenido!");
                        this.Hide();
                        IngresoVehiculosFRM inicio = new IngresoVehiculosFRM();
                        inicio.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario ya existe");
                        txtContraseña.Clear();
                        txtNom.Clear();
                        txtCorreo.Clear();

                    }
                }
            }
            
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}