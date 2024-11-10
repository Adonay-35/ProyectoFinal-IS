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
    public partial class AgregarRolForm : Form
    {
        // Variables privadas
        private string accion;
        private List<Rol> listaRoles;
        private RolController rolController; // Controlador de Roles

        // Variables para manejar la posición y tamaño del formulario
        private int PosicionFormX;
        private int PosicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        private int idRol;

        public AgregarRolForm(RolController rolController, string accion, int idRol)
        {
            InitializeComponent();

            VerificarAccion(accion);

            this.rolController = rolController;
            this.idRol = idRol;
        }

        // Método para verificar si la acción es "Agregar" o "Editar"
        private void VerificarAccion(string accion)
        {
            if (accion == "Agregar")
            {
                lblTitulo.Text = "Nuevo Rol";
            }
            else if (accion == "Editar")
            {
                lblTitulo.Text = "Editar Rol";
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error en la acción del formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Método para guardar o editar el rol
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Verificar si el campo obligatorio está lleno
            if (string.IsNullOrWhiteSpace(txtRol.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si estamos agregando un nuevo rol o editando uno existente
            if (string.IsNullOrEmpty(txtIdRol.Text))
            {
                // Agregar un nuevo rol
                string nombreRol = txtRol.Text;

                // Crear el objeto Rol
                Rol nuevoRol = new Rol
                {
                    NombreRol = nombreRol
                };

                // Llamar al controlador para insertar el nuevo rol
                bool resultado = rolController.insert(nuevoRol);

                if (resultado)
                {
                    MessageBox.Show("Rol agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Editar el rol existente
                int idRol = Convert.ToInt32(txtIdRol.Text);
                string nombreRol = txtRol.Text;

                // Crear el objeto Rol
                Rol rolExistente = new Rol
                {
                    IdRol = idRol,
                    NombreRol = nombreRol
                };

                // Llamar al controlador para actualizar el rol
                bool resultado = rolController.update(rolExistente);

                if (resultado)
                {
                    MessageBox.Show("Rol actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al actualizar el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Eventos de botones
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
