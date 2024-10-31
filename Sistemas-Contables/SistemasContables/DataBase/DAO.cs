using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.DataBase
{
    public class DAO
    {
        protected SQLiteConnection conn;

        protected const string TABLE_LIBRO_DIARIO = "librodiario";
        protected const string ID_LIBRO_DIARIO = "n_libro";
        protected const string PERIODO = "periodo";

        protected const string TABLE_PARTIDA = "partida";
        protected const string ID_PARTIDA = "idPartida";
        protected const string N_PARTIDA = "n_partida";
        protected const string FECHA = "fecha";

        protected const string TABLE_CUENTA_PARTIDA = "cuenta_partida";
        protected const string ID_CUENTA_PARTIDA = "id_cuenta_partida";
        protected const string DEBE = "debe";
        protected const string HABER = "haber";
        protected const string CONCEPTO = "concepto";

        protected const string TABLE_CUENTA = "cuenta";
        protected const string ID_CUENTA = "idCuenta";
        protected const string CODIGO = "codigo";
        protected const string NIVEL = "nivel";
        protected const string NOMBRE_CUENTA = "nombreCuenta";
        protected const string TIPO_SALDO = "tipoSaldo";
    }
}
