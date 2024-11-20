using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class CuentaPartidaDAO : DAO
    {
        private List<CuentaPartida> lista;

        public CuentaPartidaDAO()
        {
            lista = new List<CuentaPartida>();
        }

        public List<CuentaPartida> getList(int n_partida, int idLibro)
        {
            try
            {
                using (conn = Conexion.Conn)
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        int idPartida = obtenerIdPartida(n_partida, idLibro);

                        string sql = $"SELECT {TABLE_CUENTA}.{CODIGO}, {TABLE_CUENTA}.{NOMBRE_CUENTA}, " +
                                     $"{TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER} " +
                                     $"FROM {TABLE_CUENTA} " +
                                     $"INNER JOIN {TABLE_CUENTA_PARTIDA} ON {TABLE_CUENTA}.{ID_CUENTA} = {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} " +
                                     $"WHERE {ID_PARTIDA} = @idPartida";

                        command.CommandText = sql;
                        command.Connection = Conexion.Conn;
                        command.Parameters.Add(new SqlParameter("@idPartida", idPartida));

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
                                    CuentaPartida cuentaPartida = new CuentaPartida
                                    {
                                        Codigo = result[CODIGO].ToString(),
                                        Nombre = result[NOMBRE_CUENTA].ToString(),
                                        Debe = Convert.ToDouble(result[DEBE]),
                                        Haber = Convert.ToDouble(result[HABER])
                                    };

                                    lista.Add(cuentaPartida);
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

        private int obtenerIdPartida(int n_partida, int idLibro)
        {
            int id = 0;

            try
            {

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"SELECT {ID_PARTIDA} " +
                                 $"FROM {TABLE_PARTIDA} " +
                                 $"WHERE {N_PARTIDA} = @n_partida AND {ID_LIBRO_DIARIO} = @idLibro";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.Add(new SqlParameter("@n_partida", n_partida));
                    command.Parameters.Add(new SqlParameter("@idLibro", idLibro));

                    using (SqlDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                id = Convert.ToInt32(result[ID_PARTIDA]);
                            }
                        }

                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;
        }
    }
}
