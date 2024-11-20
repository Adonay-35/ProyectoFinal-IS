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
using System.Web.Security;
using System.Windows.Forms;

namespace SistemasContables.Views
{
    public partial class AgregarUsuarioForm : Form
    {
        Usuario metodosUsuarios = new Usuario();

        private string accion;

        private List<Usuario> listaUsuarios;
        private List<Estado> listaEstados;
        private List<Rol> listaRoles;
        private List<Empleado> listaEmpleados;

        private UsuarioController usuarioController;
        private EstadoController estadosController; // Asegúrate de tener este controlador
        private RolController rolesController; // Asegúrate de tener este controlador
        private EmpleadoController empleadosController; // Asegúrate de tener este controlador


        private int Usuario;


        private int PosicionFormX;
        private int PosicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        public AgregarUsuarioForm(UsuarioController usuarioController, string accion, int usuario)
        {
            InitializeComponent();

            VerificarAccion(accion);

            this.usuarioController = usuarioController;

            this.Usuario = usuario;

        }

        // verifica si la accion del formulario es Agregar o Editar
        private void VerificarAccion(string accion)
        {
            if (accion == "Agregar")
            {
                lblTitulo.Text = "Nuevo Usuario";
            }
            else if (accion == "Editar")
            {
                lblTitulo.Text = "Editar Usuario";
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error en la accion del formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Primero, verificamos si los campos obligatorios están llenos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtClave.Text) ||
                cbEmpleado.SelectedIndex == -1 || cbRol.SelectedIndex == -1 || cbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificamos si estamos en modo de edición o de agregar
            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                // Si estamos agregando un nuevo usuario
                string nombreUsuario = txtUsuario.Text;
                string claveUsuario = txtClave.Text;
                int idEmpleado = Convert.ToInt32(cbEmpleado.SelectedIndex);
                int idRol = Convert.ToInt32(cbRol.SelectedIndex);
                int idEstado = Convert.ToInt32(cbEstado.SelectedIndex);

                // Crear el objeto Usuario con los datos proporcionados
                Usuario usuario = new Usuario
                {
                    NombreUsuario = nombreUsuario,
                    ClaveUsuario = claveUsuario,
                    IdEmpleado = idEmpleado,
                    IdRol = idRol,
                    IdEstado = idEstado
                };

                // Llamamos al controlador para agregar el nuevo usuario
                bool resultado = usuarioController.insert(usuario);

                if (resultado)
                {
                    MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                // Editamos el usuario
                    int idUsuario = Convert.ToInt32(txtIdUsuario.Text);
                    string nombreUsuario = txtUsuario.Text;
                    string claveUsuario = txtClave.Text;
                    int idEmpleado = Convert.ToInt32(cbEmpleado.SelectedIndex);
                    int idRol = Convert.ToInt32(cbRol.SelectedIndex);
                    int idEstado = Convert.ToInt32(cbEstado.SelectedIndex);

                    // Crear el objeto Usuario con los datos proporcionados
                    Usuario usuario = new Usuario
                    {
                        IdUsuario = idUsuario,
                        NombreUsuario = nombreUsuario,
                        ClaveUsuario = claveUsuario,
                        IdEmpleado = idEmpleado,
                        IdRol = idRol,
                        IdEstado = idEstado
                    };

                    // Llamamos al controlador para editar el usuario
                    bool resultado = usuarioController.update(usuario);

                    if (resultado)
                    {
                        MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Aquí puedes recargar la lista de usuarios, si es necesario
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al editar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                  
            }
        }

        public void MostrarEmpleados(ComboBox cbEmpleados)
        {
            List<Empleado> datos = metodosUsuarios.ObtenerEmpleados();
            cbEmpleado.Items.Add("Selecciona una opción");
            foreach (Empleado dato in datos)
            {
                cbEmpleados.Items.Add(dato.NombresEmpleado + " " + dato.ApellidosEmpleado);
            }
        }

        public void MostrarEstados(ComboBox cbEstados)
        {
            List<Estado> datos = metodosUsuarios.ObtenerEstados();
            cbEstado.Items.Add("Selecciona una opción");
            foreach (Estado dato in datos)
            {
                cbEstados.Items.Add(dato.DescripcionEstado);
            }
        }

        public void MostrarRoles(ComboBox cbRoles)
        {
            List<Rol> datos = metodosUsuarios.ObtenerRoles();
            cbRol.Items.Add("Selecciona una opción");
            foreach (Rol dato in datos)
            {
                cbRoles.Items.Add(dato.NombreRol);
            }
        }

        private void AgregarUsuarioForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdUsuario.Text))
            {
                this.MostrarEstados(cbEstado);
                this.MostrarRoles(cbRol);
                this.MostrarEmpleados(cbEmpleado);
                cbEmpleado.SelectedIndex = 0;
                cbEstado.SelectedIndex = 0;
                cbRol.SelectedIndex = 0;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
