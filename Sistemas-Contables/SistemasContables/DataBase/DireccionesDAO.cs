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

        /*public List<Direccion> getList()
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
                                    Direccion direccion = new Direccion
                                    {
                                        IdDireccion = Convert.ToInt32(result[ID_DIRECCION]),
                                        Linea1 = result[LINEA1].ToString(),
                                        Linea2 = result[LINEA2].ToString(),
                                        CodigoPostal = result[CODIGO_POSTAL].ToString(),
                                        IdDistrito = Convert.ToInt32(result[ID_DISTRITO])
                                    };

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
        }*/
    }
}
