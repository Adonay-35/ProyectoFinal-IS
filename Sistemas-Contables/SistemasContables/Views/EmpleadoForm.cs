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
    public partial class EmpleadoForm : Form
    {
        private string accion;
        private List<Empleado> listaEmpleados;
        private List<Direccion> listaDirecciones;
        private List<Distrito> listaDistritos;


        private EmpleadoController empleadosController;
        private DireccionesController direccionesController;
        private DistritoController distritosController;


        int idEmpleado;

        int idDireccion;

        private int PosicionFormX;
        private int PosicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        public EmpleadoForm()
        {
            InitializeComponent();
            empleadosController = new EmpleadoController();
            direccionesController = new DireccionesController();
            distritosController = new DistritoController();

            llenarTablaEmpleados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = "Agregar";

            using (AgregarEmpleadoForm agregarEmpleadoForm = new AgregarEmpleadoForm(this.empleadosController, accion, idEmpleado, idDireccion))
            {
                agregarEmpleadoForm.ShowDialog();
                llenarTablaEmpleados();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tableEmpleado.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un empleado para editar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idEmpleado = Convert.ToInt32(tableEmpleado.SelectedRows[0].Cells["columnIdEmpleado"].Value);

            DialogResult resultado = MessageBox.Show("¿Deseas editar el empleado seleccionado?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string accion = "Editar";

                using (AgregarEmpleadoForm agregarEmpleadoForm = new AgregarEmpleadoForm(this.empleadosController, accion, idEmpleado , idDireccion))
                {
                    Empleado empleadoSeleccionado = empleadosController.ObtenerEmpleadoPorId(idEmpleado);

                    agregarEmpleadoForm.MostrarDirecciones(agregarEmpleadoForm.cbDireccion);
              
                    agregarEmpleadoForm.txtIdEmpleado.Text = tableEmpleado.CurrentRow.Cells["columnIdEmpleado"].Value.ToString();
                    agregarEmpleadoForm.txtNombres.Text = tableEmpleado.CurrentRow.Cells["ColumnNombres"].Value.ToString();
                    agregarEmpleadoForm.txtApellidos.Text = tableEmpleado.CurrentRow.Cells["ColumnApellidos"].Value.ToString();
                    agregarEmpleadoForm.dtpFechaNac.Text = tableEmpleado.CurrentRow.Cells["ColumnFechaNac"].Value.ToString();
                    agregarEmpleadoForm.txtDUI.Text = tableEmpleado.CurrentRow.Cells["ColumnDui"].Value.ToString();
                    agregarEmpleadoForm.txtISSS.Text = tableEmpleado.CurrentRow.Cells["ColumnIsss"].Value.ToString();
                    agregarEmpleadoForm.txtTelefono.Text = tableEmpleado.CurrentRow.Cells["ColumnTelefono"].Value.ToString();
                    agregarEmpleadoForm.txtCorreo.Text = tableEmpleado.CurrentRow.Cells["ColumnCorreo"].Value.ToString();
                    agregarEmpleadoForm.cbDireccion.SelectedItem = tableEmpleado.CurrentRow.Cells["ColumnIdDireccion"].Value.ToString();

                    agregarEmpleadoForm.ShowDialog();
                }

                llenarTablaEmpleados();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indexFila = tableEmpleado.CurrentRow.Index;
            int idEmpleado = Convert.ToInt32(tableEmpleado.Rows[indexFila].Cells["ColumnIDEmpleado"].Value);

            DialogResult res = MessageBox.Show("¿Desea eliminar el empleado seleccionado?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                empleadosController.delete(idEmpleado);

                MessageBox.Show("El empleado ha sido eliminado correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                llenarTablaEmpleados();
            }
        }

        private void llenarTablaEmpleados()
        {
            if (tableEmpleado.Rows.Count > 0 && listaEmpleados.Count > 0)
            {
                tableEmpleado.Rows.Clear();
                listaEmpleados.Clear();
            }

            listaEmpleados = empleadosController.getList();

            listaDirecciones = direccionesController.getList();

            listaDistritos = distritosController.getList();


            lblUsers.Text = "Numero de empleados registrados: " + listaEmpleados.Count;

            foreach (Empleado empleado in listaEmpleados)
            {

                // Obtener la dirección del empleado
                Direccion direccion = listaDirecciones.Find(d => d.IdDireccion == empleado.IdDireccion);

                // Obtener el distrito de la dirección
                string distrito = direccion != null ? obtenerNombreDistrito(direccion.IdDistrito) : "Desconocido";


                tableEmpleado.Rows.Add(empleado.IdEmpleado, empleado.NombresEmpleado, empleado.ApellidosEmpleado, empleado.FechaNacimiento, empleado.DuiEmpleado, empleado.IsssEmpleado, empleado.Telefono, empleado.Correo, distrito);
            }
        }


        private string obtenerNombreDistrito(int idDistrito)
        {
            Distrito distrito = listaDistritos.Find(d => d.IdDistrito == idDistrito);
            return distrito != null ? distrito.NombreDistrito : "Desconocido";
        }

        private void btnRestoreWindow_Click(object sender, EventArgs e)
        {
            this.Size = new Size(WindowWidth, WindowHeight);
            this.Location = new Point(PosicionFormX, PosicionFormY);
            this.btnMaximizar.Visible = true;
            this.btnRestoreWindow.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            PosicionFormX = this.Location.X;
            PosicionFormY = this.Location.Y;

            WindowWidth = this.Size.Width;
            WindowHeight = this.Size.Height;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.btnMaximizar.Visible = false;
            this.btnRestoreWindow.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Convierte el texto de búsqueda a minúsculas para comparación insensible a mayúsculas/minúsculas.
            string searchText = txtSearch.Text.ToLower();

            // Filtrar la lista de usuarios según los campos relevantes.
            var listaSearch = listaEmpleados.Where(empleado =>
            {
                // Comprobar si alguno de los campos contiene el texto de búsqueda.
                return empleado.NombresEmpleado.ToLower().Contains(searchText) ||
                       empleado.ApellidosEmpleado.ToLower().Contains(searchText);
                
            });

            // Cargar los datos filtrados en la tabla.
            cargarDatosSearch(listaSearch.ToList());
        }

        private void cargarDatosSearch(List<Empleado> lista)
        {
            if (tableEmpleado.RowCount > 0)
            {
                tableEmpleado.Rows.Clear();
            }

            foreach (Empleado empleado in lista)
            {
                // Obtener la dirección del empleado
                Direccion direccion = listaDirecciones.Find(d => d.IdDireccion == empleado.IdDireccion);

                // Obtener el distrito de la dirección
                string distrito = direccion != null ? obtenerNombreDistrito(direccion.IdDistrito) : "Desconocido";

                tableEmpleado.Rows.Add(empleado.IdEmpleado, empleado.NombresEmpleado, empleado.ApellidosEmpleado, empleado.FechaNacimiento, empleado.DuiEmpleado, empleado.IsssEmpleado, empleado.Telefono, empleado.Correo, distrito);
            }
        }

    }

}
