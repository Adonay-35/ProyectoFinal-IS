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

        private List<Departamento> listaDepartamentos;
        private List<Municipio> listaMunicipios;
        private List<Distrito> listaDistritos;

        private EmpleadoController empleadosController;
        private DepartamentoController departamentoController;
        private MunicipioController municipioController;
        private DistritoController distritoController;

        private int IdEmpleado;

        private Empleado empleado;



        public AgregarEmpleadoForm(EmpleadoController empleadosController, string accion, int idEmpleado)
        {
            InitializeComponent();

            VerificarAccion(accion);

            this.empleadosController = empleadosController;

            this.IdEmpleado = idEmpleado;
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
                string.IsNullOrWhiteSpace(txtTelefono.Text) || cbDepartamento.SelectedIndex == -1 ||
                cbMunicipio.SelectedIndex == -1 || cbDistrito.SelectedIndex == -1)
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
                string linea1 = txtLinea1.Text;
                string linea2 = txtLinea2.Text;
                string codigoPostal = txtCodigoPostal.Text;
                int idDepartamento = Convert.ToInt32(cbDepartamento.SelectedIndex);
                int idDistrito = Convert.ToInt32(cbDistrito.SelectedIndex);
                int idMunicipio = Convert.ToInt32(cbMunicipio.SelectedIndex);

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
                    Linea1 = linea1,
                    Linea2 = linea2,
                    CodigoPostal = codigoPostal,
                    IdDepartamento = idDepartamento,
                    IdDistrito = idDistrito,
                    IdMunicipio = idMunicipio
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
                string linea1 = txtLinea1.Text;
                string linea2 = txtLinea2.Text;
                string codigoPostal = txtCodigoPostal.Text;
                int idDepartamento = Convert.ToInt32(cbDepartamento.SelectedIndex);
                int idDistrito = Convert.ToInt32(cbDistrito.SelectedIndex);
                int idMunicipio = Convert.ToInt32(cbMunicipio.SelectedIndex);

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
                    Linea1 = linea1,
                    Linea2 = linea2,
                    CodigoPostal = codigoPostal,
                    IdDepartamento = idDepartamento,
                    IdDistrito = idDistrito,
                    IdMunicipio = idMunicipio
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

        public void MostrarDepartamentos(ComboBox cbDepartamentos)
        {
            List<Departamento> datos = metodosEmpleados.ObtenerDepartamentos();
            cbDepartamento.Items.Add("Selecciona una opción");
            foreach (Departamento dato in datos)
            {
                cbDepartamentos.Items.Add(dato.NombreDepartamento);
            }
        }

        public void MostrarMunicipios(ComboBox cbMunicipios)
        {
            List<Municipio> datos = metodosEmpleados.ObtenerMunicipios();
            cbMunicipio.Items.Add("Selecciona una opción");
            foreach (Municipio dato in datos)
            {
                cbMunicipios.Items.Add(dato.NombreMunicipio);
            }
        }

        public void MostrarDistritos(ComboBox cbDistritos)
        {
            List<Distrito> datos = metodosEmpleados.ObtenerDistritos();
            cbDistrito.Items.Add("Selecciona una opción");
            foreach (Distrito dato in datos)
            {
                cbDistritos.Items.Add(dato.NombreDistrito);
            }
        }

        private void AgregarEmpleadoForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdEmpleado.Text))
            {
                this.MostrarDepartamentos(cbDepartamento);
                this.MostrarDistritos(cbDistrito);
                this.MostrarMunicipios(cbMunicipio);
                cbDepartamento.SelectedIndex = 0;
                cbDistrito.SelectedIndex = 0;
                cbMunicipio.SelectedIndex = 0;
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
    }
}
