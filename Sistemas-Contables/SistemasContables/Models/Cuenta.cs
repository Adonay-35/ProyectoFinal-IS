using SistemasContables.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.Models
{
    public class Cuenta
    {
        private int idCuenta;
        private string nombre;
        private string codigo;
        private int nivel;
        private string tipoSaldo;

        public Cuenta(int idCuenta, string nombre, string codigo, int nivel, string tipoSaldo)
        {
            this.idCuenta = idCuenta;
            this.nombre = nombre;
            this.codigo = codigo;
            this.nivel = nivel;
            this.tipoSaldo = tipoSaldo;
        }


        public Cuenta()
        {
        }

        public int IdCuenta
        {
            get
            {
                return this.idCuenta;
            }
            set
            {
                this.idCuenta = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Codigo
        {
            get {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        public int Nivel
        {
            get
            {
                return this.nivel;
            }
            set
            {
                this.nivel = value;
            }
        }

        public string TipoSaldo
        {
            get
            {
                return this.tipoSaldo;
            }
            set
            {
                this.tipoSaldo = value;
            }

        }

        public List<Cuenta> ObtenerCuentas()
        {
            List<Cuenta> listaCuentas = new List<Cuenta>();

            try
            {
                using (SqlCommand comando = new SqlCommand("SELECT idCuenta, nombreCuenta FROM cuenta", Conexion.Conn))
                {
                    Conexion.Conn.Open();
                    using (SqlDataReader resultado = comando.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            listaCuentas.Add(new Cuenta(
                                resultado.GetInt32(0), 
                                resultado.GetString(1),
                                resultado.GetString(2),
                                resultado.GetInt32(3),
                                resultado.GetString(4)
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

            return listaCuentas;
        }

    }
}
