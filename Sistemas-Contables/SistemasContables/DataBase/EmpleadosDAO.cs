using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class EmpleadosDAO : DAO
    {
        private List<Empleado> lista;

        public EmpleadosDAO()
        {
            lista = new List<Empleado>();
        }

        public List<Empleado> getList()
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_EMPLEADO} ORDER BY {NOMBRES_EMPLEADO}";
                    command.CommandText = sql;
                    command.Connection = conn;

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
                                Empleado empleado = new Empleado();

                                empleado.IdEmpleado = Convert.ToInt32(result[ID_EMPLEADO]);
                                empleado.NombresEmpleado = result[NOMBRES_EMPLEADO].ToString();
                                empleado.ApellidosEmpleado = result[APELLIDOS_EMPLEADO].ToString();
                                empleado.FechaNacimiento = Convert.ToDateTime(result[FECHA_NACIMIENTO]);
                                empleado.DuiEmpleado = result[DUI_EMPLEADO].ToString();
                                empleado.IsssEmpleado = result[ISSS_EMPLEADO].ToString();
                                empleado.Telefono = result[TELEFONO].ToString();
                                empleado.Correo = result[CORREO].ToString();
                                empleado.IdDireccion = Convert.ToInt32(result[ID_DIRECCION]);

                                lista.Add(empleado);
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
    }
}
