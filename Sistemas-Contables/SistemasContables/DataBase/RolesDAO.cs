using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class RolesDAO : DAO
    {
        private List<Rol> lista;

        public RolesDAO()
        {
            lista = new List<Rol>();
        }

        public List<Rol> getList()
        {
            try
            {
                using (conn = Conexion.Conn)
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        string sql = $"SELECT * FROM {TABLE_ROL} ORDER BY {NOMBRE_ROL}";
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
                                    Rol rol = new Rol();

                                    rol.IdRol = Convert.ToInt32(result[ID_ROL]);
                                    rol.NombreRol = result[NOMBRE_ROL].ToString();

                                    lista.Add(rol);
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

        public bool insert(Rol rol)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"INSERT INTO {TABLE_ROL}({NOMBRE_ROL}) VALUES(@nombreRol);";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@nombreRol", rol.NombreRol);
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

        public bool update(Rol rol)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"UPDATE {TABLE_ROL} SET {NOMBRE_ROL} = @nombreRol WHERE {ID_ROL} = @idRol";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@nombreRol", rol.NombreRol);
                    command.Parameters.AddWithValue("@idRol", rol.IdRol);
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

        public void delete(int idRol)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"DELETE FROM {TABLE_ROL} WHERE {ID_ROL} = @idRol";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@idRol", idRol);
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Rol ObtenerRolPorId(int idRol)
        {
            Rol rol = null;

            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_ROL} WHERE {ID_ROL} = @idRol";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@idRol", idRol);

                    using (SqlDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows && result.Read())
                        {
                            rol = new Rol();
                            rol.IdRol = Convert.ToInt32(result[ID_ROL]);
                            rol.NombreRol = result[NOMBRE_ROL].ToString();
                        }
                    }
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return rol;
        }
    }
}
