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
        private string linea1;
        private string linea2;
        private string codigoPostal;
        private int idDepartamento;
        private int idMunicipio;
        private int idDistrito;

        private List<Empleado> listaEmpleados;
        private List<Departamento> listaDepartamentos;
        private List<Distrito> listaDistritos;
        private List<Municipio> listaMunicipios;

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

        public string Linea1
        {
            get { return this.linea1; }
            set { this.linea1 = value; }
        }

        public string Linea2
        {
            get { return this.linea2; }
            set { this.linea2 = value; }
        }

        public string CodigoPostal
        {
            get { return this.codigoPostal; }
            set { this.codigoPostal = value; }
        }

        public int IdDepartamento
        {
            get { return this.idDepartamento; }
            set { this.idDepartamento = value; }
        }

        public int IdMunicipio
        {
            get { return this.idMunicipio; }
            set { this.idMunicipio = value; }
        }

        public int IdDistrito
        {
            get { return this.idDistrito; }
            set { this.idDistrito = value; }
        }

        public List<Municipio> ObtenerMunicipios()
        {
            List<Municipio> listaMunicipios = new List<Municipio>();

            try
            {
                using (SqlCommand comando = new SqlCommand("SELECT idMunicipio, nombreMunicipio FROM Municipios", Conexion.Conn))
                {
                    Conexion.Conn.Open();

                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            listaMunicipios.Add(new Municipio(
                                resultado.GetInt32(0), // idMunicipio
                                resultado.GetString(1)  // nombreMunicipio
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

            return listaMunicipios;
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


        public List<Departamento> ObtenerDepartamentos()
        {
            List<Departamento> listaDepartamentos = new List<Departamento>();

            try
            {
                using (SqlCommand comando = new SqlCommand("SELECT idDepartamento, nombreDepartamento FROM Departamentos", Conexion.Conn))
                {
                    Conexion.Conn.Open();

                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            listaDepartamentos.Add(new Departamento(
                                resultado.GetInt32(0), // idDepartamento
                                resultado.GetString(1) // nombreDepartamento
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

            return listaDepartamentos;
        }
    }
}
