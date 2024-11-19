using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    }
}
