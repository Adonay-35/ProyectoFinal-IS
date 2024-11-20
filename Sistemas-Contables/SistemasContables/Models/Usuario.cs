using SistemasContables.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemasContables.Models
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string claveUsuario;
        private int idEmpleado;
        private int idRol;
        private int idEstado;

        private List<Usuario> listaUsuarios;
        private List<Rol> listaRol;
        private List<Estado> listaEstado;

        public int IdUsuario
        {
            get
            {
                return this.idUsuario;
            }
            set
            {
                this.idUsuario = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return this.nombreUsuario;
            }
            set
            {
                this.nombreUsuario = value;
            }
        }

        public string ClaveUsuario
        {
            get
            {
                return this.claveUsuario;
            }
            set
            {
                this.claveUsuario = value;
            }
        }

        public int IdEmpleado
        {
            get
            {
                return this.idEmpleado;
            }
            set
            {
                this.idEmpleado = value;
            }
        }

        public int IdRol
        {
            get
            {
                return this.idRol;
            }
            set
            {
                this.idRol = value;
            }
        }

        public int IdEstado
        {
            get
            {
                return this.idEstado;
            }
            set
            {
                this.idEstado = value;
            }
        }

        public List<Estado> ObtenerEstados()
        {
            List<Estado> listaEstados = new List<Estado>();

            try
            {
                using (SqlCommand comando = new SqlCommand("SELECT idEstado, descripcionEstado FROM estado", Conexion.Conn))
                {
                    Conexion.Conn.Open();
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            listaEstados.Add(new Estado(
                                resultado.GetInt32(0), // idEstado
                                resultado.GetString(1)  // descripcionEstado
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conexion.Conn.State == ConnectionState.Open)
                {
                    Conexion.Conn.Close();
                }
            }

            return listaEstados;
        }

        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            try
            {
                using (SqlCommand comando = new SqlCommand("SELECT idEmpleado, nombresEmpleado, apellidosEmpleado FROM empleado", Conexion.Conn))
                {
                    Conexion.Conn.Open();
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            listaEmpleados.Add(new Empleado(
                                resultado.GetInt32(0), // idEmpleado
                                resultado.GetString(1), // nombresEmpleado
                                resultado.GetString(2)  // apellidosEmpleado
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conexion.Conn.State == ConnectionState.Open)
                {
                    Conexion.Conn.Close();
                }
            }

            return listaEmpleados;
        }

        public List<Rol> ObtenerRoles()
        {
            List<Rol> listaRoles = new List<Rol>();

            try
            {
                using (SqlCommand comando = new SqlCommand("SELECT idRol, nombreRol FROM Roles", Conexion.Conn))
                {
                    Conexion.Conn.Open();
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            listaRoles.Add(new Rol(
                                resultado.GetInt32(0), // idRol
                                resultado.GetString(1)  // nombreRol
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conexion.Conn.State == ConnectionState.Open)
                {
                    Conexion.Conn.Close();
                }
            }

            return listaRoles;
        }
    }
}
