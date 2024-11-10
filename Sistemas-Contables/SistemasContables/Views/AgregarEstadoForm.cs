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
    public partial class AgregarEstadoForm : Form
    {
        private string accion;

        private List<Estado> listaEstados;

        private EstadoController estadoController; // Asegúrate de tener este controlador


        private int PosicionFormX;
        private int PosicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        private int Estado;

        public AgregarEstadoForm(EstadoController estadoController, string accion, int estado)
        {
            InitializeComponent();

            VerificarAccion(accion);

            this.estadoController = estadoController;

            this.Estado = estado;

        }

        // verifica si la accion del formulario es Agregar o Editar
        private void VerificarAccion(string accion)
        {
            if (accion == "Agregar")
            {
                lblTitulo.Text = "Nuevo Estado";
            }
            else if (accion == "Editar")
            {
                lblTitulo.Text = "Editar Estado";
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
            if (string.IsNullOrWhiteSpace(txtEstado.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificamos si estamos en modo de edición o de agregar
            if (string.IsNullOrEmpty(txtIdEstado.Text))
            {
                // Si estamos agregando un nuevo estado
                string estados = txtEstado.Text;
               
                // Crear el objeto Estado con los datos proporcionados
                Estado estado = new Estado
                {
                    DescripcionEstado = estados
                };

                // Llamamos al controlador para agregar el nuevo estado
                bool resultado = estadoController.insert(estado);

                if (resultado)
                {
                    MessageBox.Show("Estado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                // Editamos el estado
                Estado estadoExistente = new Estado();

                int idEstado = Convert.ToInt32(txtIdEstado.Text);

                string estados = txtEstado.Text;
              

                // Crear el objeto Estado con los datos proporcionados
                Estado estado = new Estado
                {
                    IdEstado = idEstado,
                    DescripcionEstado = estados
                };

                // Llamamos al controlador para editar el estado
                bool resultado = estadoController.update(estado);

                if (resultado)
                {
                    MessageBox.Show("Estado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al editar el estado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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
