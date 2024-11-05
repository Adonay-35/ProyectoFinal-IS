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
    class BalanceGeneralDAO : DAO
    {
        private List<Cuenta> listaCuentas;
        private List<CuentaPartida> listaSaldos;

        public BalanceGeneralDAO()
        {
            listaCuentas = new List<Cuenta>();
            listaSaldos = new List<CuentaPartida>();
        }

        public List<Cuenta> getListCuentas()
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {CODIGO}, {NOMBRE_CUENTA}, {TIPO_SALDO} FROM {TABLE_CUENTA} WHERE {CODIGO}='1' OR {CODIGO}='2' OR {CODIGO}='3'";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (listaCuentas.Count > 0)
                        {
                            listaCuentas.Clear();
                        }

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                CuentaPartida cuenta = new CuentaPartida();
                                cuenta.Codigo = result[CODIGO].ToString();
                                cuenta.Nombre = result[NOMBRE_CUENTA].ToString();
                                cuenta.TipoSaldo = result[TIPO_SALDO].ToString();

                                listaCuentas.Add(cuenta);
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
            return listaCuentas;
        }

        public List<CuentaPartida> getListSaldos(int idLibroDiario, string numeroLibro)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    Console.WriteLine(numeroLibro);
                    string sql = $"SELECT {TABLE_CUENTA}.{NOMBRE_CUENTA}, {TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER}, {TABLE_CUENTA}.{CODIGO}, {TABLE_CUENTA}.{TIPO_SALDO} ";
                    sql += $"FROM {TABLE_CUENTA_PARTIDA} INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                    sql += $"WHERE {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{CODIGO} LIKE @numeroLibro || '%'";
                    
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@idLibroDiario", idLibroDiario);
                    command.Parameters.AddWithValue("@numeroLibro", numeroLibro);

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (listaSaldos.Count > 0)
                        {
                            listaSaldos.Clear();
                        }

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                CuentaPartida cuenta = new CuentaPartida();
                                cuenta.Codigo = result[CODIGO].ToString();
                                cuenta.Nombre = result[NOMBRE_CUENTA].ToString();
                                cuenta.Debe = Convert.ToDouble(result[DEBE]);
                                cuenta.Haber = Convert.ToDouble(result[HABER]);
                                cuenta.TipoSaldo = result[TIPO_SALDO].ToString();

                                listaSaldos.Add(cuenta);
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

            return listaSaldos;
        }
    }
}
