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
    public class LibroMayorDAO : DAO
    {
        private List<string> listaCodigos;
        private List<Partida> listaPartidas;
        private CuentaPartida cuentaPartida;

        public LibroMayorDAO()
        {
            listaCodigos = new List<string>();
            listaPartidas = new List<Partida>();
            cuentaPartida = new CuentaPartida();
        }

        public List<string> getListCodigos(int idLibroDiario)
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {TABLE_CUENTA}.{CODIGO} FROM {TABLE_CUENTA_PARTIDA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} "; 
                    sql += $"WHERE {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario";


                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@idLibroDiario", idLibroDiario);

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (listaCodigos.Count > 0)
                        {
                            listaCodigos.Clear();
                        }

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                listaCodigos.Add(result[CODIGO].ToString());
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

            return listaCodigos;

        }

        public Partida getPartida(string nivel3)
        {
            Partida partida = null;

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {

                    string sql = $"SELECT {NOMBRE_CUENTA}, {TIPO_SALDO} FROM {TABLE_CUENTA} WHERE {CODIGO} = @nivel3";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@nivel3", nivel3);

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            partida = new Partida();
                            partida.ListaCuentasPartida = new List<CuentaPartida>();
                            
                            if (result.Read())
                            {
                                cuentaPartida.Nombre = result[NOMBRE_CUENTA].ToString();
                                cuentaPartida.TipoSaldo = result[TIPO_SALDO].ToString();

                                partida.ListaCuentasPartida.Add(cuentaPartida);
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

            return partida;

        }

        public List<Partida> getListPartida(string codigo, int idLibroDiario)
        {


            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT {TABLE_CUENTA}.{CODIGO}, {TABLE_PARTIDA}.{FECHA}, {TABLE_PARTIDA}.{CONCEPTO}, {TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER} FROM {TABLE_CUENTA_PARTIDA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                    sql += $"WHERE {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{CODIGO} LIKE @codigo || '%'";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@idLibroDiario", idLibroDiario);

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (listaPartidas.Count > 0)
                        {
                            listaPartidas.Clear();
                        }

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                Partida partidaAux = new Partida();
                                partidaAux.ListaCuentasPartida = new List<CuentaPartida>();
                                partidaAux.Fecha = result[FECHA].ToString();
                                partidaAux.Detalle = result[CONCEPTO].ToString();

                                cuentaPartida = new CuentaPartida();

                                cuentaPartida.Codigo = result[CODIGO].ToString();
                                cuentaPartida.Debe = Convert.ToDouble(result[DEBE].ToString());
                                cuentaPartida.Haber = Convert.ToDouble(result[HABER].ToString());

                                partidaAux.ListaCuentasPartida.Add(cuentaPartida);
                                listaPartidas.Add(partidaAux);
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

            return listaPartidas;

        }

    }
}
