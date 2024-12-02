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
    public partial class DireccionForm : Form
    {
        private string accion;

        private List<Direccion> listaDirecciones;
        private List<Distrito> listaDistritos;


        private DireccionesController direccionesController;
        private DistritoController distritosController;


        int idDireccion;

        private int PosicionFormX;
        private int PosicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        public DireccionForm()
        {
            InitializeComponent();

            direccionesController = new DireccionesController();

            distritosController = new DistritoController();

            llenarTablaDirecciones();
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            string accion = "Agregar";

            using (AgregarDireccionForm agregarDireccionForm = new AgregarDireccionForm(this.direccionesController, accion, idDireccion))
            {
                agregarDireccionForm.ShowDialog();
                llenarTablaDirecciones();
            }
        }

        private void btnModificarDireccion_Click(object sender, EventArgs e)
        {
            if (tableDireccion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una dirección para editar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idDireccion = Convert.ToInt32(tableDireccion.SelectedRows[0].Cells["columnIdDireccion"].Value);

            DialogResult resultado = MessageBox.Show("¿Deseas editar la dirección seleccionada?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string accion = "Editar";

                using (AgregarDireccionForm agregarDireccionForm = new AgregarDireccionForm(this.direccionesController, accion, idDireccion))
                {
                    Direccion direccionSeleccionada = direccionesController.ObtenerDireccionPorId(idDireccion);

                    agregarDireccionForm.MostrarDistritos(agregarDireccionForm.cbDistrito);


                    agregarDireccionForm.txtIdDireccion.Text = tableDireccion.CurrentRow.Cells["columnIdDireccion"].Value.ToString();
                    agregarDireccionForm.txtLinea1.Text = tableDireccion.CurrentRow.Cells["ColumnLinea1"].Value.ToString();
                    agregarDireccionForm.txtLinea2.Text = tableDireccion.CurrentRow.Cells["ColumnLinea2"].Value.ToString();
                    agregarDireccionForm.cbDistrito.SelectedItem = tableDireccion.CurrentRow.Cells["ColumnIdDistrito"].Value.ToString();
                    agregarDireccionForm.txtCodigoPostal.Text = tableDireccion.CurrentRow.Cells["ColumnCodigoPostal"].Value.ToString();

                    agregarDireccionForm.ShowDialog();
                }

                llenarTablaDirecciones();
            }
        }

        private void btnEliminarDireccion_Click(object sender, EventArgs e)
        {
            if (tableDireccion.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona una dirección para eliminar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idDireccion = Convert.ToInt32(tableDireccion.SelectedRows[0].Cells["columnIdDireccion"].Value);

            DialogResult res = MessageBox.Show("¿Desea eliminar la dirección seleccionada?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.OK)
            {
                direccionesController.delete(idDireccion);

                MessageBox.Show("La dirección ha sido eliminada correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                llenarTablaDirecciones();
            }
        }

        private void llenarTablaDirecciones()
        {
            if (tableDireccion.Rows.Count > 0 && listaDirecciones.Count > 0)
            {
                tableDireccion.Rows.Clear();
                listaDirecciones.Clear();
            }

            listaDirecciones = direccionesController.getList();
            listaDistritos = distritosController.getList();

            lblUsers.Text = "Número de direcciones registradas: " + listaDirecciones.Count;

            foreach (Direccion direccion in listaDirecciones)
            {
                string distrito = obtenerNombreDistrito(direccion.IdDistrito);

                tableDireccion.Rows.Add(
                    direccion.IdDireccion, direccion.Linea1, direccion.Linea2, distrito,  direccion.CodigoPostal);
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
            // Convertir el texto de búsqueda a minúsculas para comparación insensible a mayúsculas/minúsculas
            string searchText = txtSearch.Text.ToLower();

            // Filtrar la lista de direcciones según los campos relevantes
            var listaSearch = listaDirecciones.Where(direccion =>
            {
                // Obtener descripciones necesarias
                string nombreDistrito = obtenerNombreDistrito(direccion.IdDistrito).ToLower();

                // Comprobar si alguno de los campos contiene el texto de búsqueda
                return direccion.IdDireccion.ToString().Contains(searchText) ||
                       direccion.Linea1.ToLower().Contains(searchText) ||
                       direccion.Linea2.ToLower().Contains(searchText) ||
                       nombreDistrito.Contains(searchText) ||
                       direccion.CodigoPostal.ToLower().Contains(searchText);
            });

            // Cargar los datos filtrados en la tabla
            cargarDatosSearchDirecciones(listaSearch.ToList());
        }

        private void cargarDatosSearchDirecciones(List<Direccion> lista)
        {
            if (tableDireccion.RowCount > 0)
            {
                tableDireccion.Rows.Clear();
            }

            // Llenar la tabla con descripciones en lugar de IDs
            foreach (Direccion direccion in lista)
            {
                // Obtener la descripción del distrito
                string nombreDistrito = obtenerNombreDistrito(direccion.IdDistrito);


                // Agregar la fila a la tabla
                tableDireccion.Rows.Add(
                    direccion.IdDireccion,
                    direccion.Linea1,
                    direccion.Linea2,
                    nombreDistrito,
                    direccion.CodigoPostal
                );
            }
        }

    }
}
