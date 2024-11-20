using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                using (conn = Conexion.Conn)
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        string sql = $"SELECT * FROM {TABLE_EMPLEADO} ORDER BY {NOMBRES_EMPLEADO}";
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
                                    Empleado empleado = new Empleado();

                                    empleado.IdEmpleado = Convert.ToInt32(result[ID_EMPLEADO]);
                                    empleado.NombresEmpleado = result[NOMBRES_EMPLEADO].ToString();
                                    empleado.ApellidosEmpleado = result[APELLIDOS_EMPLEADO].ToString();
                                    empleado.FechaNacimiento = Convert.ToDateTime(result[FECHA_NACIMIENTO]);
                                    empleado.DuiEmpleado = result[DUI_EMPLEADO].ToString();
                                    empleado.IsssEmpleado = result[ISSS_EMPLEADO].ToString();
                                    empleado.Telefono = result[TELEFONO].ToString();
                                    empleado.Correo = result[CORREO].ToString();
                                    empleado.Linea1 = result[LINEA1].ToString();
                                    empleado.Linea2 = result[LINEA2].ToString();
                                    empleado.CodigoPostal = result[CODIGO_POSTAL].ToString();
                                    empleado.IdDepartamento = Convert.ToInt32(result[ID_DEPARTAMENTO]);
                                    empleado.IdDistrito = Convert.ToInt32(result[ID_DISTRITO]);
                                    empleado.IdMunicipio = Convert.ToInt32(result[ID_MUNICIPIO]);

                                    lista.Add(empleado);
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

        public bool insert(Empleado empleado)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"INSERT INTO {TABLE_EMPLEADO} ({NOMBRES_EMPLEADO}, {APELLIDOS_EMPLEADO}, {FECHA_NACIMIENTO}, {DUI_EMPLEADO}, {ISSS_EMPLEADO}, {TELEFONO}, {CORREO}, {LINEA1}, {LINEA2}, {CODIGO_POSTAL}, {ID_DEPARTAMENTO}, {ID_DISTRITO}, {ID_MUNICIPIO}) ";
                    sql += "VALUES (@nombresEmpleado, @apellidosEmpleado, @fechaNacimiento, @duiEmpleado, @isssEmpleado, @telefono, @correo, @linea1, @linea2, @codigoPostal, @idDepartamento, @idDistrito, @idMunicipio);";

                    command.CommandText = sql;
                    command.Connection = conn;

                    command.Parameters.AddWithValue("@nombresEmpleado", empleado.NombresEmpleado);
                    command.Parameters.AddWithValue("@apellidosEmpleado", empleado.ApellidosEmpleado);
                    command.Parameters.AddWithValue("@fechaNacimiento", empleado.FechaNacimiento.Date);
                    command.Parameters.AddWithValue("@duiEmpleado", empleado.DuiEmpleado);
                    command.Parameters.AddWithValue("@isssEmpleado", empleado.IsssEmpleado);
                    command.Parameters.AddWithValue("@telefono", empleado.Telefono);
                    command.Parameters.AddWithValue("@correo", empleado.Correo);
                    command.Parameters.AddWithValue("@linea1", empleado.Linea1);
                    command.Parameters.AddWithValue("@linea2", empleado.Linea2);
                    command.Parameters.AddWithValue("@codigoPostal", empleado.CodigoPostal);
                    command.Parameters.AddWithValue("@idDepartamento", empleado.IdDepartamento);
                    command.Parameters.AddWithValue("@idDistrito", empleado.IdDistrito);
                    command.Parameters.AddWithValue("@idMunicipio", empleado.IdMunicipio);


                    command.ExecuteNonQuery();
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

        public bool update(Empleado empleado)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"UPDATE {TABLE_EMPLEADO} SET {NOMBRES_EMPLEADO} = @nombresEmpleado, {APELLIDOS_EMPLEADO} = @apellidosEmpleado, {FECHA_NACIMIENTO} = @fechaNacimiento, {DUI_EMPLEADO} = @duiEmpleado, {ISSS_EMPLEADO} = @isssEmpleado, {TELEFONO} = @telefono, {CORREO} = @correo, {LINEA1} = @linea1, {LINEA2} = @linea2, {CODIGO_POSTAL} = @codigoPostal, {ID_DEPARTAMENTO} = @idDepartamento, {ID_DISTRITO} = @idDistrito, {ID_MUNICIPIO} = @idMunicipio WHERE {ID_EMPLEADO} = @idEmpleado";

                    command.CommandText = sql;
                    command.Connection = conn;

                    command.Parameters.AddWithValue("@nombresEmpleado", empleado.NombresEmpleado);
                    command.Parameters.AddWithValue("@apellidosEmpleado", empleado.ApellidosEmpleado);
                    command.Parameters.AddWithValue("@fechaNacimiento", empleado.FechaNacimiento.Date);
                    command.Parameters.AddWithValue("@duiEmpleado", empleado.DuiEmpleado);
                    command.Parameters.AddWithValue("@isssEmpleado", empleado.IsssEmpleado);
                    command.Parameters.AddWithValue("@telefono", empleado.Telefono);
                    command.Parameters.AddWithValue("@correo", empleado.Correo);
                    command.Parameters.AddWithValue("@linea1", empleado.Linea1);
                    command.Parameters.AddWithValue("@linea2", empleado.Linea2);
                    command.Parameters.AddWithValue("@codigoPostal", empleado.CodigoPostal);
                    command.Parameters.AddWithValue("@idDepartamento", empleado.IdDepartamento);
                    command.Parameters.AddWithValue("@idDistrito", empleado.IdDistrito);
                    command.Parameters.AddWithValue("@idMunicipio", empleado.IdMunicipio);
                    command.Parameters.AddWithValue("@idEmpleado", empleado.IdEmpleado);

                    command.ExecuteNonQuery();
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


        public void delete(int idEmpleado)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"DELETE FROM {TABLE_EMPLEADO} WHERE {ID_EMPLEADO} = @idEmpleado";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Empleado ObtenerEmpleadoPorId(int idEmpleado)
        {
            Empleado empleado = null;

            try
            {
                // Abrir la conexión
                conn = Conexion.Conn;
                conn.Open();

                // Crear el comando SQL para obtener el empleado por su ID
                using (SqlCommand command = new SqlCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_EMPLEADO} WHERE {ID_EMPLEADO} = @idEmpleado";
                    command.CommandText = sql;
                    command.Connection = conn;
                    command.Parameters.AddWithValue("@idEmpleado", idEmpleado); // Agregar el parámetro de ID

                    // Ejecutar el comando y obtener el resultado
                    using (SqlDataReader result = command.ExecuteReader())
                    {
                        // Verificar si hay resultados y asignar los valores al objeto Empleado
                        if (result.HasRows && result.Read())
                        {
                            empleado = new Empleado();

                            empleado.IdEmpleado = Convert.ToInt32(result[ID_EMPLEADO]);
                            empleado.NombresEmpleado = result[NOMBRES_EMPLEADO].ToString();
                            empleado.ApellidosEmpleado = result[APELLIDOS_EMPLEADO].ToString();
                            empleado.FechaNacimiento = Convert.ToDateTime(result[FECHA_NACIMIENTO]);
                            empleado.DuiEmpleado = result[DUI_EMPLEADO].ToString();
                            empleado.IsssEmpleado = result[ISSS_EMPLEADO].ToString();
                            empleado.Telefono = result[TELEFONO].ToString();
                            empleado.Correo = result[CORREO].ToString();
                            empleado.Linea1 = result[LINEA1].ToString();
                            empleado.Linea2 = result[LINEA2].ToString();
                            empleado.CodigoPostal = result[CODIGO_POSTAL].ToString();
                            empleado.IdDepartamento = Convert.ToInt32(result[ID_DEPARTAMENTO]);
                            empleado.IdDistrito = Convert.ToInt32(result[ID_DISTRITO]);
                            empleado.IdMunicipio = Convert.ToInt32(result[ID_MUNICIPIO]);
                        }
                    }
                }

                // Cerrar la conexión
                conn.Close();
            }
            catch (Exception exception)
            {
                // Mostrar mensaje de error si ocurre una excepción
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return empleado;
        }
    }
}
