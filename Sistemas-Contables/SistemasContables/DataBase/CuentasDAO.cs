using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_CUENTA} ORDER BY {NOMBRE_CUENTA}";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

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
                                Cuenta cuenta = new Cuenta();

                                cuenta.IdCuenta = Convert.ToInt32(result[ID_CUENTA]);
                                cuenta.Codigo = result[CODIGO].ToString();
                                cuenta.Nivel = Convert.ToInt32(result[NIVEL]);
                                cuenta.Nombre = result[NOMBRE_CUENTA].ToString();
                                cuenta.TipoSaldo = result[TIPO_SALDO].ToString();

                                lista.Add(cuenta);
                            }
                        }
                    }

                }

                conn.Close();


            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lista;

        }

    }
}
