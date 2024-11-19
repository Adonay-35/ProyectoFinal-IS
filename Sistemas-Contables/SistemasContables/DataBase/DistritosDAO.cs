using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                using (conn = Conexion.Conn)
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        string sql = $"SELECT * FROM {TABLE_DISTRITO} ORDER BY {NOMBRE_DISTRITO}";
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
                                    Distrito distrito = new Distrito
                                    {
                                        IdDistrito = Convert.ToInt32(result[ID_DISTRITO]),
                                        NombreDistrito = result[NOMBRE_DISTRITO].ToString(),
                                        IdMunicipio = Convert.ToInt32(result[ID_MUNICIPIO])
                                    };

                                    lista.Add(distrito);
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
    }
}
