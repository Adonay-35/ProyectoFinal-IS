using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_DIRECCION} ORDER BY {LINEA1}";
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lista;
        }
    }
}
