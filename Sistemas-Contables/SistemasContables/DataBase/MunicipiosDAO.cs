using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class MunicipiosDAO : DAO
    {
        private List<Municipio> lista;

        public MunicipiosDAO()
        {
            lista = new List<Municipio>();
        }

        public List<Municipio> getList()
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_MUNICIPIO} ORDER BY {NOMBRE_MUNICIPIO}";
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
                                Municipio municipio = new Municipio();

                                municipio.IdMunicipio = Convert.ToInt32(result[ID_MUNICIPIO]);
                                municipio.NombreMunicipio = result[NOMBRE_MUNICIPIO].ToString();
                                municipio.IdDepartamento = Convert.ToInt32(result[ID_DEPARTAMENTO]);

                                lista.Add(municipio);
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
