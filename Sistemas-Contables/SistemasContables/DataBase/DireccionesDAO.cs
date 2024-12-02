using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class DireccionesDAO : DAO
    {
        private List<Direccion> lista;

        public DireccionesDAO()
        {
            lista = new List<Direccion>();
        }

        public List<Direccion> getList()
        {
            try
            {
                using (conn = Conexion.Conn)
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        string sql = $"SELECT * FROM {TABLE_DIRECCION} ORDER BY {LINEA1}";
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
                                    Direccion direccion = new Direccion();

                                    direccion.IdDireccion = Convert.ToInt32(result[ID_DIRECCION]);
                                    direccion.Linea1 = result[LINEA1].ToString();
                                    direccion.Linea2 = result[LINEA2].ToString();
                                    direccion.CodigoPostal = result[CODIGO_POSTAL].ToString();
                                    direccion.IdDistrito = Convert.ToInt32(result[ID_DISTRITO]);

                                    lista.Add(direccion);
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

        public bool insert(Direccion direccion)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"INSERT INTO {TABLE_DIRECCION} ({LINEA1}, {LINEA2}, {CODIGO_POSTAL}, {ID_DISTRITO}) ";
                    sql += "VALUES (@linea1, @linea2, @codigoPostal, @idDistrito);";

                    command.CommandText = sql;
                    command.Connection = conn;

                    command.Parameters.AddWithValue("@linea1", direccion.Linea1);
                    command.Parameters.AddWithValue("@linea2", direccion.Linea2);
                    command.Parameters.AddWithValue("@codigoPostal", direccion.CodigoPostal);
                    command.Parameters.AddWithValue("@idDistrito", direccion.IdDistrito);

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

        public bool update(Direccion direccion)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"UPDATE {TABLE_DIRECCION} SET {LINEA1} = @linea1, {LINEA2} = @linea2, {CODIGO_POSTAL} = @codigoPostal, {ID_DISTRITO} = @idDistrito WHERE {ID_DIRECCION} = @idDireccion";

                    command.CommandText = sql;
                    command.Connection = conn;

                    command.Parameters.AddWithValue("@linea1", direccion.Linea1);
                    command.Parameters.AddWithValue("@linea2", direccion.Linea2);
                    command.Parameters.AddWithValue("@codigoPostal", direccion.CodigoPostal);
                    command.Parameters.AddWithValue("@idDistrito", direccion.IdDistrito);
                    command.Parameters.AddWithValue("@idDireccion", direccion.IdDireccion);

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

        public void delete(int idDireccion)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"DELETE FROM {TABLE_DIRECCION} WHERE {ID_DIRECCION} = @idDireccion";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@idDireccion", idDireccion);
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Direccion ObtenerDireccionPorId(int idDireccion)
        {
            Direccion direccion = null;

            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_DIRECCION} WHERE {ID_DIRECCION} = @idDireccion";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@idDireccion", idDireccion);

                    using (SqlDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows && result.Read())
                        {
                            direccion = new Direccion();

                            direccion.IdDireccion = Convert.ToInt32(result[ID_DIRECCION]);
                            direccion.Linea1 = result[LINEA1].ToString();
                            direccion.Linea2 = result[LINEA2].ToString();
                            direccion.CodigoPostal = result[CODIGO_POSTAL].ToString();
                            direccion.IdDistrito = Convert.ToInt32(result[ID_DISTRITO]);
                        }
                    }
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return direccion;
        }
    }
}
