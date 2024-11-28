using iTextSharp.text.pdf.codec.wmf;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class EstadosDAO : DAO
    {
        private List<Estado> lista;

        public EstadosDAO()
        {
            lista = new List<Estado>();
        }

        public List<Estado> getList()
        {
            try
            {
                using (conn = Conexion.Conn)
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        string sql = $"SELECT * FROM {TABLE_ESTADO} ORDER BY {DESCRIPCION_ESTADO}";
                        command.CommandText = sql;
                        command.Connection = Conexion.Conn;

                        using (SqlDataReader result = command.ExecuteReader())
                        {
                            if (result.HasRows)
                            {
                                if (lista.Count > 0)
                                {
                                    lista.Clear();
                                }

                                while (result.Read())
                                {
                                    Estado estado = new Estado();

                                    estado.IdEstado = Convert.ToInt32(result[ID_ESTADO]);
                                    estado.DescripcionEstado = result[DESCRIPCION_ESTADO].ToString();

                                    lista.Add(estado);
                                }
                            }
                        }
                    }
                    conn.Close();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lista;
        }

        public bool insert(Estado estado)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"INSERT INTO {TABLE_ESTADO}({DESCRIPCION_ESTADO}) VALUES(@descripcionEstado);";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@descripcionEstado", estado.DescripcionEstado);
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

        public bool update(Estado estado)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"UPDATE {TABLE_ESTADO} SET {DESCRIPCION_ESTADO} = @descripcionEstado WHERE {ID_ESTADO} = @idEstado";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@descripcionEstado", estado.DescripcionEstado);
                    command.Parameters.AddWithValue("@idEstado", estado.IdEstado);
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

        public void delete(int idEstado)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"DELETE FROM {TABLE_ESTADO} WHERE {ID_ESTADO} = @idEstado";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@idEstado", idEstado);
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Estado ObtenerEstadoPorId(int idEstado)
        {
            Estado estado = null;

            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_ESTADO} WHERE {ID_ESTADO} = @idEstado";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@idEstado", idEstado);

                    using (SqlDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows && result.Read())
                        {
                            estado = new Estado();
                            estado.IdEstado = Convert.ToInt32(result[ID_ESTADO]);
                            estado.DescripcionEstado = result[DESCRIPCION_ESTADO].ToString();
                        }
                    }
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estado;
        }

        public Estado ObtenerDescripcionEstado(string descripcionEstado)
        {
            Estado estado = null;

            try
            {
                using (SqlConnection conn = Conexion.Conn)
                {
                    conn.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        string sql = $"SELECT {DESCRIPCION_ESTADO}, {ID_ESTADO} FROM {TABLE_ESTADO} WHERE {DESCRIPCION_ESTADO} = @descripcionEstado";
                        command.CommandText = sql;
                        command.Connection = conn;
                        command.Parameters.AddWithValue("@descripcionEstado", descripcionEstado);

                        using (SqlDataReader result = command.ExecuteReader())
                        {
                            if (result.HasRows && result.Read())
                            {
                                estado = new Estado();
                                estado.IdEstado = Convert.ToInt32(result[ID_ESTADO]);
                                estado.DescripcionEstado = result[DESCRIPCION_ESTADO].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return estado;
        }


    }
}
