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
    public partial class AgregarDireccionForm : Form
    {
        Direccion metodosDireciones = new Direccion();


        private List<Distrito> listaDistritos;

        private DireccionesController direccionesController;

        private int IdDireccion;


        public AgregarDireccionForm(DireccionesController direccionesController, string accion, int IdDireccion)
        {
            InitializeComponent();

            this.direccionesController = direccionesController;

            VerificarAccion(accion);

            this.IdDireccion = IdDireccion;
        }

        // Verifica si la acción del formulario es Agregar o Editar
        private void VerificarAccion(string accion)
        {
            if (accion == "Agregar")
            {
                lblTitulo.Text = "Nueva Direccion";
            }
            else if (accion == "Editar")
            {
                lblTitulo.Text = "Editar Direccion";
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error en la acción del formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Primero, verificamos si los campos obligatorios están llenos
            if (string.IsNullOrWhiteSpace(txtLinea1.Text) || string.IsNullOrWhiteSpace(txtLinea2.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoPostal.Text) || cbDistrito.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificamos si estamos en modo de edición o de agregar
            if (string.IsNullOrEmpty(txtIdDireccion.Text))
            {
                // Si estamos agregando una nueva dirección
                string linea1 = txtLinea1.Text;
                string linea2 = txtLinea2.Text;
                string codigoPostal = txtCodigoPostal.Text;
                int idDistrito = Convert.ToInt32(cbDistrito.SelectedIndex);

                // Crear el objeto Direccion con los datos proporcionados
                Direccion direccion = new Direccion
                {
                    Linea1 = linea1,
                    Linea2 = linea2,
                    CodigoPostal = codigoPostal,
                    IdDistrito = idDistrito
                };

                // Llamamos al controlador para agregar la nueva dirección
                bool resultado = direccionesController.insert(direccion);

                if (resultado)
                {
                    MessageBox.Show("Dirección agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar la dirección.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Editamos la dirección
                int idDireccion = Convert.ToInt32(txtIdDireccion.Text);
                string linea1 = txtLinea1.Text;
                string linea2 = txtLinea2.Text;
                string codigoPostal = txtCodigoPostal.Text;
                int idDistrito = Convert.ToInt32(cbDistrito.SelectedIndex);

                // Crear el objeto Direccion con los datos proporcionados
                Direccion direccion = new Direccion
                {
                    IdDireccion = idDireccion,
                    Linea1 = linea1,
                    Linea2 = linea2,
                    CodigoPostal = codigoPostal,
                    IdDistrito = idDistrito
                };

                // Llamamos al controlador para editar la dirección
                bool resultado = direccionesController.update(direccion);

                if (resultado)
                {
                    MessageBox.Show("Dirección actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al editar la dirección.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void MostrarDistritos(ComboBox cbDistritos)
        {
            List<Distrito> datos = metodosDireciones.ObtenerDistritos();
            cbDistrito.Items.Add("Selecciona una opción");
            foreach (Distrito dato in datos)
            {
                cbDistritos.Items.Add(dato.NombreDistrito);
            }
        }

        private void AgregarDireccionForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdDireccion.Text))
            {
                this.MostrarDistritos(cbDistrito);
                cbDistrito.SelectedIndex = 0;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
