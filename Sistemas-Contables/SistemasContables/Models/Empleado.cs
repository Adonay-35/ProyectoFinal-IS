using SistemasContables.DataBase;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemasContables.Models
{
    public class Empleado
    {
        private int idEmpleado;
        private string nombresEmpleado;
        private string apellidosEmpleado;
        private DateTime fechaNacimiento;
        private string duiEmpleado;
        private string isssEmpleado;
        private string telefono;
        private string correo;
        private int idDireccion;

        private List<Empleado> listaEmpleados;
        private List<Distrito> listaDistritos;

        public Empleado(int idEmpleado, string nombres, string apellidos)
        {
            this.idEmpleado = idEmpleado;
            this.nombresEmpleado = nombres;
            this.apellidosEmpleado = apellidos;
        }

        public Empleado()
        {
        }

        public int IdEmpleado
        {
            get { return this.idEmpleado; }
            set { this.idEmpleado = value; }
        }

        public string NombresEmpleado
        {
            get { return this.nombresEmpleado; }
            set { this.nombresEmpleado = value; }
        }

        public string ApellidosEmpleado
        {
            get { return this.apellidosEmpleado; }
            set { this.apellidosEmpleado = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        public string DuiEmpleado
        {
            get { return this.duiEmpleado; }
            set { this.duiEmpleado = value; }
        }

        public string IsssEmpleado
        {
            get { return this.isssEmpleado; }
            set { this.isssEmpleado = value; }
        }

        public string Telefono
        {
            get { return this.telefono; }
            set { this.telefono = value; }
        }

        public string Correo
        {
            get { return this.correo; }
            set { this.correo = value; }
        }

        public int IdDireccion
        {
            get { return this.idDireccion; }
            set { this.idDireccion = value; }
        }

        public List<Direccion> ObtenerDirecciones()
        {
            List<Direccion> listaDirecciones = new List<Direccion>();

            try
            {
                using (SqlCommand comando = new SqlCommand("SELECT idDireccion, linea1, linea2, codigoPostal, idDistrito FROM Direcciones", Conexion.Conn))
                {
                    Conexion.Conn.Open();

                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            listaDirecciones.Add(new Direccion(
                                resultado.GetInt32(0),
                                resultado.GetString(1),
                                resultado.GetString(1)  

                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conexion.Conn.State == ConnectionState.Open)
                {
                    Conexion.Conn.Close();
                }
            }

            return listaDirecciones;
        }


        public List<Distrito> ObtenerDistritos()
        {
            List<Distrito> listaDistritos = new List<Distrito>();

            try
            {
                using (SqlCommand comando = new SqlCommand("SELECT idDistrito, nombreDistrito FROM Distritos", Conexion.Conn))
                {
                    Conexion.Conn.Open();

                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            listaDistritos.Add(new Distrito(
                                resultado.GetInt32(0), // idDistrito
                                resultado.GetString(1)  // nombreDistrito
                            ));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conexion.Conn.State == ConnectionState.Open)
                {
                    Conexion.Conn.Close();
                }
            }

            return listaDistritos;
        }
    }
}
