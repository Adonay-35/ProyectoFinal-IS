using SistemasContables.controller;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemasContables.Views
{
    public partial class UsuarioForm : Form
    {
        private string accion;
        private List<Usuario> listaUsuarios;
        private List<Estado> listaEstados;
        private List<Rol> listaRoles;
        private List<Empleado> listaEmpleados;

        private UsuarioController usuariosController;
        private EstadoController estadosController; // Asegúrate de tener este controlador
        private RolController rolesController; // Asegúrate de tener este controlador
        private EmpleadoController empleadosController; // Asegúrate de tener este controlador

        int idUsuario;

        private int PosicionFormX;
        private int PosicionFormY;
        private int WindowWidth;
        private int WindowHeight;


        public UsuarioForm()
        {
            InitializeComponent();
            usuariosController = new UsuarioController(); // Inicializamos el controlador de usuarios
            empleadosController = new EmpleadoController(); // Inicializamos el controlador de empleados
            rolesController = new RolController(); // Inicializamos el controlador de roles
            estadosController = new EstadoController(); // Inicializamos el controlador de estados

            llenarTablaUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = "Agregar";

            using (AgregarUsuarioForm agregarUsuarioForm = new AgregarUsuarioForm(this.usuariosController, accion, idUsuario))
            {
                agregarUsuarioForm.ShowDialog();
                llenarTablaUsuarios();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (tableUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un usuario para editar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del usuario seleccionado
            int idUsuario = Convert.ToInt32(tableUsuario.SelectedRows[0].Cells["columnIdUsuario"].Value);

            // Confirmar la acción de editar
            DialogResult resultado = MessageBox.Show("¿Deseas editar el usuario seleccionado?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Abrir el formulario de edición
                string accion = "Editar";

                // Usamos el ID del usuario seleccionado para obtener los datos correspondientes
                using (AgregarUsuarioForm agregarUsuarioForm = new AgregarUsuarioForm(this.usuariosController, accion, idUsuario))
                {
                    // Cargar los datos del usuario seleccionado en el formulario
                    Usuario usuarioSeleccionado = usuariosController.ObtenerUsuarioPorId(idUsuario);

                    agregarUsuarioForm.MostrarEmpleados(agregarUsuarioForm.cbEmpleado);
                    agregarUsuarioForm.MostrarRoles(agregarUsuarioForm.cbRol);
                    agregarUsuarioForm.MostrarEstados(agregarUsuarioForm.cbEstado);

                    // Asignamos los valores del usuario al formulario
                    agregarUsuarioForm.txtIdUsuario.Text = tableUsuario.CurrentRow.Cells["columnIdUsuario"].Value.ToString();
                    agregarUsuarioForm.txtUsuario.Text = tableUsuario.CurrentRow.Cells["ColumnUsuario"].Value.ToString();
                    agregarUsuarioForm.txtClave.Text = tableUsuario.CurrentRow.Cells["ColumnClave"].Value.ToString();
                    agregarUsuarioForm.cbEmpleado.SelectedItem = tableUsuario.CurrentRow.Cells["ColumnEmpleado"].Value.ToString();// Ajusta esto si usas un índice o el ID directamente
                    agregarUsuarioForm.cbRol.SelectedItem = tableUsuario.CurrentRow.Cells["ColumnRol"].Value.ToString(); // Ajusta esto si usas un índice o el ID directamente
                    agregarUsuarioForm.cbEstado.SelectedItem = tableUsuario.CurrentRow.Cells["ColumnEstado"].Value.ToString(); // Ajusta esto si usas un índice o el ID directamente

                    // Mostrar el formulario de edición
                    agregarUsuarioForm.ShowDialog();
                }

                // Recargar la lista de usuarios después de la edición
                llenarTablaUsuarios();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indexFila = tableUsuario.CurrentRow.Index;
            int idUsuario = Convert.ToInt32(tableUsuario.Rows[indexFila].Cells["ColumnIDUsuario"].Value);

            DialogResult res = MessageBox.Show("¿Desea eliminar el usuario seleccionado?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                usuariosController.delete(idUsuario); // Eliminar usuario

                MessageBox.Show("El usuario ha sido eliminado correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                llenarTablaUsuarios();
            }
        }

        private string obtenerDescripcionEstado(int idEstado)
        {
            Estado estado = listaEstados.Find(e => e.IdEstado == idEstado);
            return estado != null ? estado.DescripcionEstado : "Desconocido";
        }

        private string obtenerDescripcionRol(int idRol)
        {
            Rol rol = listaRoles.Find(r => r.IdRol == idRol);
            return rol != null ? rol.NombreRol : "Desconocido";
        }

        private string NombreCompleto(int idEmpleado)
        {
            // Busca el empleado en la lista de empleados usando el ID
            Empleado empleado = listaEmpleados.Find(e => e.IdEmpleado == idEmpleado);
            // Devuelve el nombre completo o "Desconocido" si no se encuentra
            return empleado != null ? $"{empleado.NombresEmpleado} {empleado.ApellidosEmpleado}" : "Desconocido";
        }


        // Método para llenar la tabla de usuarios
        private void llenarTablaUsuarios()
        {
            // Limpiar la tabla y las listas si es necesario
            if (tableUsuario.Rows.Count > 0 && listaUsuarios.Count > 0)
            {
                tableUsuario.Rows.Clear();
                listaUsuarios.Clear();
            }

            // Obtener la lista de usuarios, estados y roles
            listaUsuarios = usuariosController.getList();
            listaEstados = estadosController.getList();
            listaRoles = rolesController.getList();
            listaEmpleados = empleadosController.getList();

            // Llenar la tabla con descripciones en lugar de IDs
            foreach (Usuario usuario in listaUsuarios)
            {
                // Obtener la descripción del estado y del rol
                string descripcionEstado = obtenerDescripcionEstado(usuario.IdEstado);
                string descripcionRol = obtenerDescripcionRol(usuario.IdRol);
                string nombreCompletoEmpleado = NombreCompleto(usuario.IdEmpleado);

                // Agregar la fila a la tabla
                tableUsuario.Rows.Add(usuario.IdUsuario, usuario.NombreUsuario, usuario.ClaveUsuario, nombreCompletoEmpleado, descripcionRol, descripcionEstado);
            }
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

    }
}
