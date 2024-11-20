using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class Conexion
    {
        private const string dataConnection = "Server=LAPTOP-MA3ASCVJ;Database=ContaAgil;User Id=sa;Password=root;MultipleActiveResultSets=True";
        static private SqlConnection conn = null;

        static public SqlConnection Conn
        {
            get
            {
                if (conn == null || conn.ConnectionString == string.Empty)
                {
                    conn = new SqlConnection(dataConnection);
                }
                return conn;
            }
        }


        private Conexion() { }

        static public void TestConnection()
        {
            try
            {
                Conn.Open();
                MessageBox.Show("¡Conexión exitosa a SQL Server!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Conn.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Error al conectar a SQL Server: {exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
