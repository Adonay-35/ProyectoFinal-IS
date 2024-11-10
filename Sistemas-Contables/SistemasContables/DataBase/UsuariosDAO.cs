using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class UsuariosDAO : DAO
    {
        private List<Usuario> lista = null;

        public UsuariosDAO()
        {
            lista = new List<Usuario>();
        }

        public List<Usuario> getList()
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_USUARIO} ORDER BY {NOMBRE_USUARIO}";
                    command.CommandText = sql;
                    command.Connection = conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            if (lista.Count > 0)
                            {
                                lista.Clear();
                            }

                            while (result.Read())
                            {
                                Usuario usuario = new Usuario();

                                usuario.IdUsuario = Convert.ToInt32(result[ID_USUARIO]);
                                usuario.NombreUsuario = result[NOMBRE_USUARIO].ToString();
                                usuario.ClaveUsuario = result[CLAVE_USUARIO].ToString();
                                usuario.IdEmpleado = Convert.ToInt32(result[ID_EMPLEADO]);
                                usuario.IdRol = Convert.ToInt32(result[ID_ROL]);
                                usuario.IdEstado = Convert.ToInt32(result[ID_ESTADO]);

                                lista.Add(usuario);
                            }
                        }
                    }
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lista;
        }

        public bool insert(Usuario usuario)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLE_USUARIO}({NOMBRE_USUARIO}, {CLAVE_USUARIO}, {ID_EMPLEADO}, {ID_ROL}, {ID_ESTADO}) ";
                    sql += "VALUES(@nombreUsuario, @claveUsuario, @idEmpleado, @idRol, @idEstado);";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                    command.Parameters.AddWithValue("@claveUsuario", usuario.ClaveUsuario);
                    command.Parameters.AddWithValue("@idEmpleado", usuario.IdEmpleado);
                    command.Parameters.AddWithValue("@idRol", usuario.IdRol);
                    command.Parameters.AddWithValue("@idEstado", usuario.IdEstado);
                    command.ExecuteNonQuery();
                }

                conn.Close();

                return true;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }


        public bool update(Usuario usuario)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"UPDATE {TABLE_USUARIO} SET {NOMBRE_USUARIO} = @nombreUsuario, {CLAVE_USUARIO} = @claveUsuario, {ID_EMPLEADO} = @idEmpleado, {ID_ROL} = @idRol, {ID_ESTADO} = @idEstado WHERE {ID_USUARIO} = @idUsuario";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                    command.Parameters.AddWithValue("@claveUsuario", usuario.ClaveUsuario);
                    command.Parameters.AddWithValue("@idEmpleado", usuario.IdEmpleado);
                    command.Parameters.AddWithValue("@idRol", usuario.IdRol);
                    command.Parameters.AddWithValue("@idEstado", usuario.IdEstado);
                    command.Parameters.AddWithValue("@idUsuario", usuario.IdUsuario);
                    command.ExecuteNonQuery();
                }

                conn.Close();

                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }


        public void delete(int idUsuario)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"DELETE FROM {TABLE_USUARIO} WHERE {ID_USUARIO} = @idUsuario";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            Usuario usuario = null;

            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_USUARIO} WHERE {NOMBRE_USUARIO} = @nombreUsuario";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows && result.Read())
                        {
                            usuario = new Usuario();

                            usuario.IdUsuario = Convert.ToInt32(result[ID_USUARIO]);
                            usuario.NombreUsuario = result[NOMBRE_USUARIO].ToString();
                            usuario.ClaveUsuario = result[CLAVE_USUARIO].ToString();
                            usuario.IdEmpleado = Convert.ToInt32(result[ID_EMPLEADO]);
                            usuario.IdRol = Convert.ToInt32(result[ID_ROL]);
                            usuario.IdEstado = Convert.ToInt32(result[ID_ESTADO]);

                        }
                    }
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return usuario;
        }

        public Usuario ObtenerUsuarioPorId(int idUsuario)
        {
            Usuario usuario = null;

            try
            {
                // Abrir la conexión
                conn = Conexion.Conn;
                conn.Open();

                // Crear el comando SQL para obtener el usuario por su ID
                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_USUARIO} WHERE {ID_USUARIO} = @idUsuario";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@idUsuario", idUsuario); // Agregar el parámetro de ID

                    // Ejecutar el comando y obtener el resultado
                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        // Verificar si hay resultados y asignar los valores al objeto Usuario
                        if (result.HasRows && result.Read())
                        {
                            usuario = new Usuario();

                            usuario.IdUsuario = Convert.ToInt32(result[ID_USUARIO]);
                            usuario.NombreUsuario = result[NOMBRE_USUARIO].ToString();
                            usuario.ClaveUsuario = result[CLAVE_USUARIO].ToString();
                            usuario.IdEmpleado = Convert.ToInt32(result[ID_EMPLEADO]);
                            usuario.IdRol = Convert.ToInt32(result[ID_ROL]);
                            usuario.IdEstado = Convert.ToInt32(result[ID_ESTADO]);
                        }
                    }
                }

                // Cerrar la conexión
                conn.Close();
            }
            catch (Exception exception)
            {
                // Mostrar mensaje de error si ocurre una excepción
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return usuario;
        }

    }
}
