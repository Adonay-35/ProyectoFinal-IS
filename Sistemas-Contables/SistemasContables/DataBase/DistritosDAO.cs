using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class DistritosDAO : DAO
    {
        private List<Distrito> lista;

        public DistritosDAO()
        {
            lista = new List<Distrito>();
        }

        public List<Distrito> getList()
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_DISTRITO} ORDER BY {NOMBRE_DISTRITO}";
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
                                Distrito distrito = new Distrito();

                                distrito.IdDistrito = Convert.ToInt32(result[ID_DISTRITO]);
                                distrito.NombreDistrito = result[NOMBRE_DISTRITO].ToString();
                                distrito.IdMunicipio = Convert.ToInt32(result[ID_MUNICIPIO]);

                                lista.Add(distrito);
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
