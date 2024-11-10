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
    public partial class RolForm : Form
    {
        private string accion;
        private List<Rol> listaRoles;
        private RolController rolesController;

        int idRol;

        private int PosicionFormX;
        private int PosicionFormY;
        private int WindowWidth;
        private int WindowHeight;

        public RolForm()
        {
            InitializeComponent();

            rolesController = new RolController(); // Inicializamos el controlador de roles

            llenarTablaRoles();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            accion = "Agregar";

            using (AgregarRolForm agregarRolForm = new AgregarRolForm(this.rolesController, accion, idRol))
            {
                agregarRolForm.ShowDialog();
                llenarTablaRoles();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tableRoles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un rol para editar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idRol = Convert.ToInt32(tableRoles.SelectedRows[0].Cells["columnIdRol"].Value);

            DialogResult resultado = MessageBox.Show("¿Deseas editar el rol seleccionado?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string accion = "Editar";

                using (AgregarRolForm agregarRolForm = new AgregarRolForm(this.rolesController, accion, idRol))
                {
                    Rol rolSeleccionado = rolesController.ObtenerRolPorId(idRol);

                    agregarRolForm.txtIdRol.Text = tableRoles.CurrentRow.Cells["columnIdRol"].Value.ToString();
                    agregarRolForm.txtRol.Text = tableRoles.CurrentRow.Cells["ColumnRol"].Value.ToString();

                    agregarRolForm.ShowDialog();
                }

                llenarTablaRoles();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indexFila = tableRoles.CurrentRow.Index;
            int idRol = Convert.ToInt32(tableRoles.Rows[indexFila].Cells["ColumnIdRol"].Value);

            DialogResult res = MessageBox.Show("¿Desea eliminar el rol seleccionado?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                rolesController.delete(idRol);

                MessageBox.Show("El rol ha sido eliminado correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                llenarTablaRoles();
            }
        }

        private void llenarTablaRoles()
        {
            if (tableRoles.Rows.Count > 0 && listaRoles.Count > 0)
            {
                tableRoles.Rows.Clear();
                listaRoles.Clear();
            }

            listaRoles = rolesController.getList();

            foreach (Rol rol in listaRoles)
            {
                tableRoles.Rows.Add(rol.IdRol, rol.NombreRol);
            }
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
