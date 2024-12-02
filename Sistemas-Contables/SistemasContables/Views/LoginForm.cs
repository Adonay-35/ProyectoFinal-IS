using SistemasContables.controller;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.Views
{
    public partial class LoginForm : Form
    {
        private UsuarioController usuarioController;
        public static string nombreUsuario;

        private string accion;
        int idUsuario;

        int idEmpleado;

        int idDireccion;

        public LoginForm()
        {
            InitializeComponent();
            usuarioController = new UsuarioController();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            nombreUsuario = txtNombreUsuario.Text;
            //string claveUsuario = txtClaveUsuario.Text;

            string claveHasheada = Encryptar.GetSHA256(txtClaveUsuario.Text.Trim());

            if (usuarioController.Login(nombreUsuario, claveHasheada))
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar el formulario de login y abrir el formulario de inicio
                this.Hide(); // Oculta el LoginForm
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close(); // Cierra LoginForm después de que se cierre InicioForm
            }
            else
            {
                MessageBox.Show("Nombre de usuario o clave incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            accion = "Agregar";

            using (AgregarUsuarioForm agregarUsuarioForm = new AgregarUsuarioForm(this.usuarioController, accion, idUsuario, idEmpleado, idDireccion))
            {
                agregarUsuarioForm.ShowDialog();
            }
        }
    }
}
