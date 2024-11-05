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
    class EstadoDeResultadosDAO : DAO
    {
        private Double Debe = 0;
        private Double Haber = 0;
        private Double ingresos = 0;
        private Double costos = 0;
        private Double gastos = 0;

        public EstadoDeResultadosDAO()
        {

        }

        public double getTotalIngresos(int idLibroDiario)
        {
            Debe = totalDebe(idLibroDiario, "5");
            Haber = totalHaber(idLibroDiario, "5");
            ingresos = Haber - Debe;

            return ingresos;
        }

        public double getTotalCostos(int idLibroDiario)
        {

            Debe = totalDebe(idLibroDiario, "41");
            Haber = totalHaber(idLibroDiario, "41");
            costos = Debe - Haber;

            return costos;
        }

        public double getTotalGastos(int idLibroDiario)
        {
            gastos = totalDebe(idLibroDiario, "42");

            return gastos;
        }

        private double totalDebe(int idLibro, string codigo)
        {
            double total = 0;

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT SUM({TABLE_CUENTA_PARTIDA}.{DEBE}) FROM {TABLE_CUENTA_PARTIDA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                    sql += $"WHERE  {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{CODIGO} LIKE @codigo || '%' ";


                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@idLibroDiario", idLibro);
                    command.Parameters.AddWithValue("@codigo", codigo);
                    var result = command.ExecuteScalar();

                    if(!string.IsNullOrEmpty(result.ToString()))
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

        private double totalHaber(int idLibro, string codigo)
        {
            double total = 0;

            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT SUM({TABLE_CUENTA_PARTIDA}.{HABER}) FROM {TABLE_CUENTA_PARTIDA} ";
                    sql += $"INNER JOIN {TABLE_CUENTA} ON {TABLE_CUENTA_PARTIDA}.{ID_CUENTA} = {TABLE_CUENTA}.{ID_CUENTA} ";
                    sql += $"INNER JOIN {TABLE_PARTIDA} ON {TABLE_CUENTA_PARTIDA}.{ID_PARTIDA} = {TABLE_PARTIDA}.{ID_PARTIDA} ";
                    sql += $"WHERE  {TABLE_PARTIDA}.{ID_LIBRO_DIARIO} = @idLibroDiario AND {TABLE_CUENTA}.{CODIGO} LIKE @codigo || '%' ";


                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue("@idLibroDiario", idLibro);
                    command.Parameters.AddWithValue("@codigo", codigo);
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

    }
}