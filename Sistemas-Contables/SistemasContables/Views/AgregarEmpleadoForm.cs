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
    public partial class AgregarEmpleadoForm : Form
    {
        Empleado metodosEmpleados = new Empleado();

        private string accion;

        private List<Distrito> listaDistritos;
        private List<Direccion> listaDirecciones;


        private EmpleadoController empleadosController;
        private DistritoController distritoController;
        private DireccionesController direccionesController;


        private int IdEmpleado;

        int idDireccion;


        private Empleado empleado;

        public AgregarEmpleadoForm(EmpleadoController empleadosController, string accion, int idEmpleado, int idDireccion)
        {
            InitializeComponent();

            VerificarAccion(accion);

            this.empleadosController = empleadosController;

            this.direccionesController = new DireccionesController();

            this.IdEmpleado = idEmpleado;

            this.idDireccion = idDireccion;
        }

        // Verifica si la acción del formulario es Agregar o Editar
        private void VerificarAccion(string accion)
        {
            if (accion == "Agregar")
            {
                lblTitulo.Text = "Nuevo Empleado";
            }
            else if (accion == "Editar")
            {
                lblTitulo.Text = "Editar Empleado";
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
            if (string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) || cbDireccion.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificamos si estamos en modo de edición o de agregar
            if (string.IsNullOrEmpty(txtIdEmpleado.Text))
            {
                // Si estamos agregando un nuevo empleado
                string nombresEmpleado = txtNombres.Text;
                string apellidosEmpleado = txtApellidos.Text;
                DateTime fechaNacimiento = Convert.ToDateTime(dtpFechaNac.Text);
                string duiEmpleado = txtDUI.Text;
                string issEmpleado = txtISSS.Text;
                string telefono = txtTelefono.Text;
                string correo = txtCorreo.Text;
                int IdDireccion = Convert.ToInt32(cbDireccion.SelectedIndex);

                // Crear el objeto Empleado con los datos proporcionados
                Empleado empleado = new Empleado
                {
                    NombresEmpleado = nombresEmpleado,
                    ApellidosEmpleado = apellidosEmpleado,
                    FechaNacimiento = fechaNacimiento,
                    DuiEmpleado = duiEmpleado,
                    IsssEmpleado = issEmpleado,
                    Telefono = telefono,
                    Correo = correo,
                    IdDireccion = IdDireccion
                };

                // Llamamos al controlador para agregar el nuevo empleado
                bool resultado = empleadosController.insert(empleado);

                if (resultado)
                {
                    MessageBox.Show("Empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Editamos el empleado
                int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
                string nombresEmpleado = txtNombres.Text;
                string apellidosEmpleado = txtApellidos.Text;
                DateTime fechaNacimiento = Convert.ToDateTime(dtpFechaNac.Text);
                string duiEmpleado = txtDUI.Text;
                string issEmpleado = txtISSS.Text;
                string telefono = txtTelefono.Text;
                string correo = txtCorreo.Text;
                int IdDireccion = Convert.ToInt32(cbDireccion.SelectedIndex);

                // Crear el objeto Empleado con los datos proporcionados
                Empleado empleado = new Empleado
                {
                    IdEmpleado = idEmpleado,
                    NombresEmpleado = nombresEmpleado,
                    ApellidosEmpleado = apellidosEmpleado,
                    FechaNacimiento = fechaNacimiento,
                    DuiEmpleado = duiEmpleado,
                    IsssEmpleado = issEmpleado,
                    Telefono = telefono,
                    Correo = correo,
                    IdDireccion = IdDireccion
                };

                // Llamamos al controlador para editar el empleado
                bool resultado = empleadosController.update(empleado);

                if (resultado)
                {
                    MessageBox.Show("Empleado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al editar el empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void MostrarDirecciones(ComboBox cbEmpleados)
        {
            List<Direccion> datos = metodosEmpleados.ObtenerDirecciones();
            cbDireccion.Items.Add("Selecciona una opción");
            foreach (Direccion dato in datos)
            {
                cbEmpleados.Items.Add(dato.Linea1);
            }
        }

        private void AgregarEmpleadoForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdEmpleado.Text))
            {
                this.MostrarDirecciones(cbDireccion);
                cbDireccion.SelectedIndex = 0;
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

        private void dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            // Formatear la fecha como "dd/MM/yyyy" y mostrarla en un MessageBox
            string fechaFormateada = dtpFechaNac.Value.ToString("dd/MM/yyyy");

            // Opcional: Asignar la fecha formateada a un TextBox si lo necesitas
            dtpFechaNac.Text = fechaFormateada;

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            accion = "Agregar";


            using (AgregarDireccionForm agregarDireccionForm = new AgregarDireccionForm(this.direccionesController, accion, idDireccion))
            {
                // Registrar un evento FormClosed para actualizar el ComboBox al cerrar
                agregarDireccionForm.FormClosed += (s, args) =>
                {
                    // Actualizar el ComboBox de empleados
                    cbDireccion.Items.Clear(); // Limpiar el ComboBox actual
                    this.MostrarDirecciones(cbDireccion); // Volver a cargar los datos

                    // Volver a seleccionar el primer ítem (o un valor predeterminado)
                    cbDireccion.SelectedIndex = 0;
                };

                agregarDireccionForm.ShowDialog(); // Mostrar el formulario
            }
        }
    }
}
