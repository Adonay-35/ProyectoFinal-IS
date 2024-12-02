using SistemasContables.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemasContables.Models
{
    public class Direccion
    {
        private int idDireccion;
        private string linea1;
        private string linea2;
        private string codigoPostal;
        private int idDistrito;

        public Direccion(int idDireccion, string linea1, string linea2) { 
        
            this.idDireccion = idDireccion;
            this.linea1 = linea1;
            this.linea2 = linea2;

        }

    public Direccion()
        {
        }

        public int IdDireccion
        {
            get { return this.idDireccion; }
            set { this.idDireccion = value; }
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

        public int IdDistrito
        {
            get { return this.idDistrito; }
            set { this.idDistrito = value; }
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
