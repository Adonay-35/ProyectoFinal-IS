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
    public partial class EstadoForm : Form
    {
        private string accion;
        private List<Estado> listaEstados;

        private EstadoController estadosController; // Asegúrate de tener este controlador
       

        int idEstado;

        private int PosicionFormX;
        private int PosicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        public EstadoForm()
        {
            InitializeComponent();

            estadosController = new EstadoController(); // Inicializamos el controlador de estados

            llenarTablaEstados();

        }


        private void btnRestoreWindow_Click(object sender, EventArgs e)
        {
            this.Size = new Size(WindowWidth, WindowHeight);
            // devulvo a la ventana a la posicion previo a maximizar la ventana
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
            // obtengo la posicion de la ventana previo a maximizar la ventana
            PosicionFormX = this.Location.X;
            PosicionFormY = this.Location.Y;

            // obtengo la tamaño de la ventana previo a maximizar la ventana
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = "Agregar";

            using (AgregarEstadoForm agregarUsuarioForm = new AgregarEstadoForm(this.estadosController, accion, idEstado))
            {
                agregarUsuarioForm.ShowDialog();
                llenarTablaEstados();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (tableEstados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un estado para editar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del estado seleccionado
            int idEstado = Convert.ToInt32(tableEstados.SelectedRows[0].Cells["columnIdEstado"].Value);

            // Confirmar la acción de editar
            DialogResult resultado = MessageBox.Show("¿Deseas editar el estado seleccionado?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Abrir el formulario de edición
                string accion = "Editar";

                // Usamos el ID del usuario seleccionado para obtener los datos correspondientes
                using (AgregarEstadoForm agregarEstadoForm = new AgregarEstadoForm(this.estadosController, accion, idEstado))
                {
                    // Cargar los datos del usuario seleccionado en el formulario
                    Estado estadoSeleccionado = estadosController.ObtenerEstadoPorId(idEstado);

                    // Asignamos los valores del usuario al formulario
                    agregarEstadoForm.txtIdEstado.Text = tableEstados.CurrentRow.Cells["columnIdEstado"].Value.ToString();
                    agregarEstadoForm.txtEstado.Text = tableEstados.CurrentRow.Cells["ColumnEstado"].Value.ToString();

                    // Mostrar el formulario de edición
                    agregarEstadoForm.ShowDialog();
                }

                // Recargar la lista de estados después de la edición
                llenarTablaEstados();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indexFila = tableEstados.CurrentRow.Index;
            int idEstado = Convert.ToInt32(tableEstados.Rows[indexFila].Cells["ColumnIdEstado"].Value);

            DialogResult res = MessageBox.Show("¿Desea eliminar el estado seleccionado?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                estadosController.delete(idEstado); // Eliminar estado

                MessageBox.Show("El estado ha sido eliminado correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                llenarTablaEstados();
            }
        }

        private void llenarTablaEstados()
        {
            // Limpiar la tabla y las listas si es necesario
            if (tableEstados.Rows.Count > 0 && listaEstados.Count > 0)
            {
                tableEstados.Rows.Clear();
                listaEstados.Clear();
            }

            // Obtener la lista de usuarios, estados y roles
            listaEstados = estadosController.getList();

            // Llenar la tabla con descripciones en lugar de IDs
            foreach (Estado estado in listaEstados)
            {
                // Agregar la fila a la tabla
                tableEstados.Rows.Add(estado.IdEstado, estado.DescripcionEstado);
            }
        }


    }
}
