using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class DepartamentosDAO : DAO
    {
        private List<Departamento> lista;

        public DepartamentosDAO()
        {
            lista = new List<Departamento>();
        }

        public List<Departamento> getList()
        {
            try
            {
                using (conn = Conexion.Conn)
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        string sql = $"SELECT * FROM {TABLE_DEPARTAMENTO} ORDER BY {NOMBRE_DEPARTAMENTO}";
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
                                    Departamento departamento = new Departamento
                                    {
                                        IdDepartamento = Convert.ToInt32(result[ID_DEPARTAMENTO]),
                                        NombreDepartamento = result[NOMBRE_DEPARTAMENTO].ToString()
                                    };

                                    lista.Add(departamento);
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
