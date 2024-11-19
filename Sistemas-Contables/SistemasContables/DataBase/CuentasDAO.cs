using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class CuentasDAO : DAO
    {
        private List<Cuenta> lista;

        public CuentasDAO()
        {
            lista = new List<Cuenta>();
        }

        public List<Cuenta> getList()
        {
            try
            {
                using (conn = Conexion.Conn)
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        string sql = $"SELECT * FROM {TABLE_CUENTA} ORDER BY {NOMBRE_CUENTA}";
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
                                    Cuenta cuenta = new Cuenta
                                    {
                                        IdCuenta = Convert.ToInt32(result[ID_CUENTA]),
                                        Codigo = result[CODIGO].ToString(),
                                        Nivel = Convert.ToInt32(result[NIVEL]),
                                        Nombre = result[NOMBRE_CUENTA].ToString(),
                                        TipoSaldo = result[TIPO_SALDO].ToString()
                                    };

                                    lista.Add(cuenta);
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
