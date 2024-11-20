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
        private List<Departamento> listaDepartamentos;
        private List<Distrito> listaDistritos;
        private List<Municipio> listaMunicipios;

        private EmpleadoController empleadosController;
        private DepartamentoController departamentosController;
        private DistritoController distritosController;
        private MunicipioController municipiosController;

        int idEmpleado;

        private int PosicionFormX;
        private int PosicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        public EmpleadoForm()
        {
            InitializeComponent();
            empleadosController = new EmpleadoController();
            departamentosController = new DepartamentoController();
            distritosController = new DistritoController();
            municipiosController = new MunicipioController();

            llenarTablaEmpleados();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = "Agregar";

            using (AgregarEmpleadoForm agregarEmpleadoForm = new AgregarEmpleadoForm(this.empleadosController, accion, idEmpleado))
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

                using (AgregarEmpleadoForm agregarEmpleadoForm = new AgregarEmpleadoForm(this.empleadosController, accion, idEmpleado))
                {
                    Empleado empleadoSeleccionado = empleadosController.ObtenerEmpleadoPorId(idEmpleado);

                    agregarEmpleadoForm.MostrarDepartamentos(agregarEmpleadoForm.cbDepartamento);
                    agregarEmpleadoForm.MostrarDistritos(agregarEmpleadoForm.cbDistrito);
                    agregarEmpleadoForm.MostrarMunicipios(agregarEmpleadoForm.cbMunicipio);

                    agregarEmpleadoForm.txtIdEmpleado.Text = tableEmpleado.CurrentRow.Cells["columnIdEmpleado"].Value.ToString();
                    agregarEmpleadoForm.txtNombres.Text = tableEmpleado.CurrentRow.Cells["ColumnNombres"].Value.ToString();
                    agregarEmpleadoForm.txtApellidos.Text = tableEmpleado.CurrentRow.Cells["ColumnApellidos"].Value.ToString();
                    agregarEmpleadoForm.dtpFechaNac.Text = tableEmpleado.CurrentRow.Cells["ColumnFechaNac"].Value.ToString();
                    agregarEmpleadoForm.txtDUI.Text = tableEmpleado.CurrentRow.Cells["ColumnDui"].Value.ToString();
                    agregarEmpleadoForm.txtISSS.Text = tableEmpleado.CurrentRow.Cells["ColumnIsss"].Value.ToString();
                    agregarEmpleadoForm.txtTelefono.Text = tableEmpleado.CurrentRow.Cells["ColumnTelefono"].Value.ToString();
                    agregarEmpleadoForm.txtCorreo.Text = tableEmpleado.CurrentRow.Cells["ColumnCorreo"].Value.ToString();
                    agregarEmpleadoForm.txtLinea1.Text = tableEmpleado.CurrentRow.Cells["ColumnLinea1"].Value.ToString();
                    agregarEmpleadoForm.txtLinea2.Text = tableEmpleado.CurrentRow.Cells["ColumnLinea2"].Value.ToString();
                    agregarEmpleadoForm.txtCodigoPostal.Text = tableEmpleado.CurrentRow.Cells["ColumnCodigoPostal"].Value.ToString();
                    agregarEmpleadoForm.cbDepartamento.SelectedItem = tableEmpleado.CurrentRow.Cells["ColumnIdDepartamento"].Value.ToString();
                    agregarEmpleadoForm.cbDistrito.SelectedItem = tableEmpleado.CurrentRow.Cells["ColumnIdDistrito"].Value.ToString();
                    agregarEmpleadoForm.cbMunicipio.SelectedItem = tableEmpleado.CurrentRow.Cells["ColumnIdMunicipio"].Value.ToString();

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
            listaDepartamentos = departamentosController.getList();
            listaDistritos = distritosController.getList();
            listaMunicipios = municipiosController.getList();

            foreach (Empleado empleado in listaEmpleados)
            {
                string departamento = obtenerNombreDepartamento(empleado.IdDepartamento);
                string distrito = obtenerNombreDistrito(empleado.IdDistrito);
                string municipio = obtenerNombreMunicipio(empleado.IdMunicipio);

                tableEmpleado.Rows.Add(empleado.IdEmpleado, empleado.NombresEmpleado, empleado.ApellidosEmpleado, empleado.FechaNacimiento, empleado.DuiEmpleado, empleado.IsssEmpleado, empleado.Telefono, empleado.Correo, empleado.Linea1, empleado.Linea2, empleado.CodigoPostal, departamento, municipio, distrito);
            }
        }

        private string obtenerNombreDepartamento(int idDepartamento)
        {
            Departamento departamento = listaDepartamentos.Find(d => d.IdDepartamento == idDepartamento);
            return departamento != null ? departamento.NombreDepartamento : "Desconocido";
        }

        private string obtenerNombreDistrito(int idDistrito)
        {
            Distrito distrito = listaDistritos.Find(d => d.IdDistrito == idDistrito);
            return distrito != null ? distrito.NombreDistrito : "Desconocido";
        }

        private string obtenerNombreMunicipio(int idMunicipio)
        {
            Municipio municipio = listaMunicipios.Find(m => m.IdMunicipio == idMunicipio);
            return municipio != null ? municipio.NombreMunicipio : "Desconocido";
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
    }
}
