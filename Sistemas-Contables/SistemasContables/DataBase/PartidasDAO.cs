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
    public class PartidasDAO : DAO
    {
        private int idPartida;
        private int idCuenta;
        private List<Partida> lista = null;

        public PartidasDAO()
        {
            lista = new List<Partida>();
        }

        public bool insert(Partida partida)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLE_PARTIDA}({ID_PARTIDA}, {FECHA}, {CONCEPTO}, {N_PARTIDA}, {ID_LIBRO_DIARIO}) ";
                    sql += "VALUES(NULL, @fecha, @concepto, @n_partida, @id_libro_diario);";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@fecha", partida.Fecha);
                    command.Parameters.AddWithValue("@concepto", partida.Detalle);
                    command.Parameters.AddWithValue("@n_partida", partida.N_Partida);
                    command.Parameters.AddWithValue("@id_libro_diario", partida.IdLibro);
                    command.ExecuteNonQuery();

                    this.idPartida = obtenerIdUltimaPartida(partida.IdLibro);

                    foreach (CuentaPartida cuentaPartida in partida.ListaCuentasPartida)
                    {
                        this.idCuenta = obtenerIdCuentaActual(cuentaPartida.Codigo);
                        cuentaPartida.IdCuenta = this.idCuenta;
                        cuentaPartida.IdPartida = this.idPartida;

                        insertarCuentaPartida(cuentaPartida);
                    }

                }

                conn.Close();

                return true;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

        }

        public List<Partida> getList(int idLibroDiario)
        {

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_PARTIDA} WHERE {ID_LIBRO_DIARIO} = @n_libro";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@n_libro", idLibroDiario);

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (lista.Count > 0)
                        {
                            lista.Clear();
                        }

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                Partida partida = new Partida();

                                partida.IdPartida = Convert.ToInt32(result[ID_PARTIDA].ToString());
                                partida.Fecha = result[FECHA].ToString();
                                partida.Detalle = result[CONCEPTO].ToString();
                                partida.N_Partida = Convert.ToInt32(result[N_PARTIDA].ToString());
                                partida.IdLibro = Convert.ToInt32(result[ID_LIBRO_DIARIO].ToString());
                                partida.ListaCuentasPartida = getListCuentasPartida(partida.IdPartida);

                                lista.Add(partida);
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

        public bool update(Partida partida)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"UPDATE {TABLE_PARTIDA} SET {FECHA} = @fecha, {CONCEPTO} = @concepto WHERE {N_PARTIDA} =  @n_partida";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@fecha", partida.Fecha);
                    command.Parameters.AddWithValue("@concepto", partida.Detalle);
                    command.Parameters.AddWithValue("@n_partida", partida.N_Partida);
                    command.ExecuteNonQuery();

                    //Ingreso las cuentasPartidas a sus respectiva partida a la database

                    idPartida = obtenerIdPartida(partida.N_Partida, partida.IdLibro);

                    deleteCuentaPartida(idPartida);

                    foreach (CuentaPartida cuentaPartida in partida.ListaCuentasPartida)
                    {
                        this.idCuenta = obtenerIdCuentaActual(cuentaPartida.Codigo);
                        cuentaPartida.IdCuenta = this.idCuenta;
                        cuentaPartida.IdPartida = this.idPartida;

                        insertarCuentaPartida(cuentaPartida);
                    }

                }

                conn.Close();

                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                return false;
            }
        }

        public void delete(int n_partida, int idLibro)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {

                    idPartida = obtenerIdPartida(n_partida, idLibro);

                    deleteCuentaPartida(idPartida);

                    string sql = $"DELETE FROM {TABLE_PARTIDA} WHERE {ID_PARTIDA} = @idPartida";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@idPartida", idPartida);
                    command.ExecuteNonQuery();

                    reorderPartidas(n_partida);

                }

                conn.Close();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Partida getPartida(int n_partida, int idLibro)
        {
            Partida partida = null;

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    idPartida = obtenerIdPartida(n_partida, idLibro);

                    string sql = $"SELECT {FECHA}, {CONCEPTO} FROM {TABLE_PARTIDA} WHERE {ID_PARTIDA} = @idPartida";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@idPartida", idPartida);

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {

                            while (result.Read())
                            {
                                partida = new Partida();

                                partida.Fecha = result[FECHA].ToString();
                                partida.Detalle = result[CONCEPTO].ToString();

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

        public double total(int idLibro, string campoCalcular)
        {
            double total = 0;

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = "";
                    string descripcionDebito = "Debito Fiscal IVA";
                    string descripcionCredito = "Credito Fiscal IVA";

                    if (campoCalcular == "debito_total")
                    {
                        sql = $"SELECT SUM({DEBE}) FROM {TABLE_CUENTA_PARTIDA} INNER JOIN {TABLE_PARTIDA} ";
                        sql += $"ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} WHERE {ID_LIBRO_DIARIO} = @idLibroDiario";

                    } else if(campoCalcular == "credito_total")
                    {
                        sql = $"SELECT SUM({HABER}) FROM {TABLE_CUENTA_PARTIDA} INNER JOIN {TABLE_PARTIDA} ";
                        sql += $"ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} WHERE {ID_LIBRO_DIARIO} = @idLibroDiario";
                    }
                    else if(campoCalcular == "debito_debe")
                    {

                        sql = $"SELECT SUM({DEBE}) FROM {TABLE_CUENTA_PARTIDA} ";
                        sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                        sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                        sql += $"WHERE {ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{NOMBRE_CUENTA} = '{descripcionDebito}'";
                    }
                    else if (campoCalcular == "debito_haber")
                    {
                        sql = $"SELECT SUM({HABER}) FROM {TABLE_CUENTA_PARTIDA} ";
                        sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                        sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                        sql += $"WHERE {ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{NOMBRE_CUENTA} =  '{descripcionDebito}'";
                    }
                    else if(campoCalcular == "credito_debe")
                    {
                        sql = $"SELECT SUM({DEBE}) FROM {TABLE_CUENTA_PARTIDA} ";
                        sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                        sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                        sql += $"WHERE {ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{NOMBRE_CUENTA} =  '{descripcionCredito}'";
                    }
                    else if(campoCalcular == "credito_haber")
                    {
                        sql = $"SELECT SUM({HABER}) FROM {TABLE_CUENTA_PARTIDA} ";
                        sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                        sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                        sql += $"WHERE {ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{NOMBRE_CUENTA} =  '{descripcionCredito}'";
                    }
                    else
                    {
                        MessageBox.Show("Error no se encontro el campo a calcular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return 0;
                    }


                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@idLibroDiario", idLibro);
                    var result = command.ExecuteScalar();

                    if (!string.IsNullOrEmpty(result.ToString()))
                    {
                        total = Convert.ToDouble(result);
                    }

                }

                conn.Close();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return total;

        }

        private void insertarCuentaPartida(CuentaPartida cuentaPartida)
        {
            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"INSERT INTO  {TABLE_CUENTA_PARTIDA}({ID_CUENTA_PARTIDA}, {ID_CUENTA}, {ID_PARTIDA}, {DEBE}, {HABER}) ";
                sql += "VALUES (NULL, @idCuenta, @idPartida, @debe, @haber);";

                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.AddWithValue("@idCuenta", cuentaPartida.IdCuenta);
                command.Parameters.AddWithValue("@idPartida", cuentaPartida.IdPartida);
                command.Parameters.AddWithValue("@debe", cuentaPartida.Debe);
                command.Parameters.AddWithValue("@haber", cuentaPartida.Haber);
                command.ExecuteNonQuery();

            }

        }

        private int obtenerIdUltimaPartida(int idLibroDiario)
        {
            int id = 0;

            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"SELECT {ID_PARTIDA} FROM {TABLE_PARTIDA} WHERE {ID_LIBRO_DIARIO} =@idLibroDiario ORDER BY {ID_PARTIDA} DESC LIMIT 1;";
                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.AddWithValue("@idLibroDiario", idLibroDiario);

                using(SQLiteDataReader result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        while (result.Read())
                        {

                            id = Convert.ToInt32(result[ID_PARTIDA].ToString());

                        }
                    }
                }

            }

            return id;
        }

        private int obtenerIdCuentaActual(string codigoCuenta)
        {
            int id = 0;

            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"SELECT {ID_CUENTA} FROM {TABLE_CUENTA} WHERE {CODIGO} = @codigo";
                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.AddWithValue("@codigo", codigoCuenta);
               
                using (SQLiteDataReader result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        while (result.Read())
                        {

                            id = Convert.ToInt32(result[ID_CUENTA].ToString());

                        }
                    }

                }

            }

            return id;
        }

        private List<CuentaPartida> getListCuentasPartida(int idPartida)
        {
            List<CuentaPartida> listaCuentasPartida = new List<CuentaPartida>(); ;


            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"SELECT {TABLE_CUENTA}.{CODIGO}, {TABLE_CUENTA}.{NOMBRE_CUENTA}, {TABLE_CUENTA_PARTIDA}.{DEBE}, {TABLE_CUENTA_PARTIDA}.{HABER} FROM {TABLE_CUENTA} ";
                sql += $"INNER JOIN {TABLE_CUENTA_PARTIDA} ON {TABLE_CUENTA}.{ID_CUENTA} = {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} WHERE {ID_PARTIDA} = @idPartida";

                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.AddWithValue("@idPartida", idPartida);

                using (SQLiteDataReader result = command.ExecuteReader())
                {
                    if (listaCuentasPartida.Count > 0)
                    {
                        listaCuentasPartida.Clear();
                    }

                    if (result.HasRows)
                    {

                        while (result.Read())
                        {
                            CuentaPartida cuentaPartida = new CuentaPartida();

                            cuentaPartida.Codigo = result[CODIGO].ToString();
                            cuentaPartida.Nombre = result[NOMBRE_CUENTA].ToString();
                            cuentaPartida.Debe = Convert.ToDouble(result[DEBE].ToString());
                            cuentaPartida.Haber = Convert.ToDouble(result[HABER].ToString());

                            listaCuentasPartida.Add(cuentaPartida);
                        }
                    }
                }

            }


            return listaCuentasPartida;

        }

        private void deleteCuentaPartida(int idPartida)
        {
            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"DELETE FROM {TABLE_CUENTA_PARTIDA} WHERE {ID_PARTIDA} = @idPartida ";

                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.AddWithValue("@idPartida", idPartida);
                command.ExecuteNonQuery();

            }
        }

        private int obtenerIdPartida(int n_partida, int idLibro)
        {
            int id = 0;

            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"SELECT {ID_PARTIDA} FROM {TABLE_PARTIDA} WHERE {N_PARTIDA} = @n_partida AND {ID_LIBRO_DIARIO} = @idLibro;";
                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.AddWithValue("@n_partida", n_partida);
                command.Parameters.AddWithValue("@idLibro", idLibro);

                using (SQLiteDataReader result = command.ExecuteReader())
                {
                    if (result.HasRows)
                    {
                        while (result.Read())
                        {

                            id = Convert.ToInt32(result[ID_PARTIDA].ToString());

                        }
                    }
                }

            }

            return id;
        }

        private void reorderPartidas(int n_partida)
        {
            using (SQLiteCommand command = new SQLiteCommand())
            {
                string sql = $"UPDATE {TABLE_PARTIDA} SET {N_PARTIDA} = {N_PARTIDA} - 1  WHERE {N_PARTIDA} > @n_partida;";

                command.CommandText = sql;
                command.Connection = Conexion.Conn;
                command.Parameters.AddWithValue("@n_partida", n_partida);
                command.ExecuteNonQuery();

            }
        }

        public bool VerificarAjusteIVA(int idLibro)
        {
            bool verificar = false;

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {

                    string sql = $"SELECT * FROM {TABLE_PARTIDA} WHERE {ID_LIBRO_DIARIO} = @idLibroDiario AND {CONCEPTO} = 'Ajuste de IVA'";
                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@idLibroDiario", idLibro);

                    using(SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                verificar = true;
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

            return verificar;
        }

    }
}
