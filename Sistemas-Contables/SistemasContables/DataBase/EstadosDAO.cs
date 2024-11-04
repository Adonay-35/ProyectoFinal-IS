using SistemasContables.Models;
using System;
using System.Collections.Generic;
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
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_ESTADO} ORDER BY {DESCRIPCION_ESTADO}";
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lista;
        }
    }
}
