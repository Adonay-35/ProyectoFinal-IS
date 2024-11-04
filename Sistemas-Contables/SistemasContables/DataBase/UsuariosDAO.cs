using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class UsuariosDAO : DAO
    {
        private List<Usuario> lista;

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
    }
}
