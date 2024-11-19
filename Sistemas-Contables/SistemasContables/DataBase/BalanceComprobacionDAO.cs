using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    class BalanceComprobacionDAO : DAO
    {
        private List<CuentaPartida> listaCuentas;
        private List<CuentaPartida> listaCuentaPartidas;

        public BalanceComprobacionDAO()
        {
            listaCuentas = new List<CuentaPartida>();
            listaCuentaPartidas = new List<CuentaPartida>();
        }

        public List<CuentaPartida> getListCuentas()
        {
            try
            {

                using (conn = Conexion.Conn)
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        string sql = $"SELECT {CODIGO}, {NOMBRE_CUENTA}, {TIPO_SALDO} " +
                                     $"FROM {TABLE_CUENTA} " +
                                     $"WHERE {CODIGO} = '1' OR {CODIGO} = '2' OR {CODIGO} = '31' OR {CODIGO} = '5' OR {CODIGO} = '41' OR {CODIGO} = '42'";

                        command.CommandText = sql;
                        command.Connection = Conexion.Conn;

                        using (SqlDataReader result = command.ExecuteReader())
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

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaCuentas;
        }

        public List<CuentaPartida> getListCuentasPartidas(string codigo, int idLibroDiario)
        {
            try
            {
                using (conn = Conexion.Conn)
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        string sql = $"SELECT {TABLE_CUENTA}.{CODIGO}, {TABLE_CUENTA}.{NOMBRE_CUENTA}, {TABLE_PARTIDA}.{N_PARTIDA}, " +
                                     $"{TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER} " +
                                     $"FROM {TABLE_CUENTA_PARTIDA} " +
                                     $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} " +
                                     $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} " +
                                     $"WHERE {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{CODIGO} LIKE @codigo + '%'";

                        command.CommandText = sql;
                        command.Connection = Conexion.Conn;
                        command.Parameters.Add(new SqlParameter("@codigo", codigo));
                        command.Parameters.Add(new SqlParameter("@idLibroDiario", idLibroDiario));

                        using (SqlDataReader result = command.ExecuteReader())
                        {
                            if (listaCuentaPartidas.Count > 0)
                            {
                                listaCuentaPartidas.Clear();
                            }

                            if (result.HasRows)
                            {
                                while (result.Read())
                                {
                                    CuentaPartida cuentaPartida = new CuentaPartida();
                                    cuentaPartida.IdPartida = Convert.ToInt32(result[N_PARTIDA]);
                                    cuentaPartida.Codigo = result[CODIGO].ToString();
                                    cuentaPartida.Nombre = result[NOMBRE_CUENTA].ToString();
                                    cuentaPartida.Debe = Convert.ToDouble(result[DEBE]);
                                    cuentaPartida.Haber = Convert.ToDouble(result[HABER]);

                                    listaCuentaPartidas.Add(cuentaPartida);
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

            return listaCuentaPartidas;
        }
    }
}
