using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

// Para establecer la conexion a la database se utilizo Singleton Pattern

namespace SistemasContables.DataBase
{

    public class Conexion
    {
        private const string dataConnection = @"Data Source=./database.db; PRAGMA foreign_keys=ON; UTF8Encoding=True; Version=3";

        static private SQLiteConnection conn = null;
        static public SQLiteConnection Conn
        {
            get
            {

                if(conn == null)
                {
                    conn = new SQLiteConnection(dataConnection);

                    if (!File.Exists("./database.db"))
                    {
                        CreateDataBase();
                    }

                }

                return conn;
            }
        }

        private Conexion()
        {
            
        }

        static private void CreateDataBase() {

            try
            {
                SQLiteConnection.CreateFile("./database.db");

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = @"PRAGMA foreign_keys = ON;";

                    sql += "CREATE TABLE librodiario(";
                    sql += "n_libro INTEGER PRIMARY KEY AUTOINCREMENT,";
                    sql += "periodo text(200)";
                    sql += ");";

                    sql += "CREATE TABLE cuenta(";
                    sql += "idCuenta INTEGER PRIMARY KEY AUTOINCREMENT,";
                    sql += "codigo INTEGER(10),";
                    sql += "nivel INTEGER(10),";
                    sql += "nombreCuenta TEXT(100),";
                    sql += "tipoSaldo TEXT(100)";
                    sql += ");";

                    sql += "CREATE TABLE partida(";
                    sql += "idPartida INTEGER PRIMARY KEY AUTOINCREMENT,";
                    sql += "fecha TEXT(100),";
                    sql += "concepto TEXT,";
                    sql += "n_partida INTEGER,";
                    sql += "n_libro INTEGER,";
                    sql += "FOREIGN KEY(n_libro) REFERENCES librodiario(n_libro) ";
                    sql += "ON DELETE CASCADE ";
                    sql += "ON UPDATE CASCADE";
                    sql += ");";

                    sql += "CREATE TABLE cuenta_partida(";
                    sql += "id_cuenta_partida INTEGER PRIMARY KEY AUTOINCREMENT,";
                    sql += "idCuenta INTEGER,";
                    sql += "idPartida INTEGER,";
                    sql += "debe REAL,";
                    sql += "haber REAL,";
                    sql += "FOREIGN KEY(idCuenta) REFERENCES cuenta(idCuenta) ";
                    sql += "ON DELETE CASCADE ON UPDATE CASCADE ";
                    sql += "FOREIGN KEY(idPartida) REFERENCES partida(idPartida) ";
                    sql += "ON DELETE CASCADE ON UPDATE CASCADE";
                    sql += ");";

                    sql += cuentasInsert();

                    command.CommandText = sql;
                    command.Connection = conn;
                    command.ExecuteNonQuery();

                }

                conn.Close();

            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        static private string cuentasInsert()
        {
            string cuentas = "";

            cuentas += "INSERT INTO cuenta VALUES";
            cuentas += "(1, 1, 1, 'ACTIVO', 'Deudor'),";
            cuentas += "(2, 11, 2, 'ACTIVO CORRIENTE', 'Deudor'),";
            cuentas += "(3, 1101, 3, 'EFECTIVO Y EQUIVALENTES DE EFECTIVO', 'Deudor'),";
            cuentas += "(4, 110101, 4, 'Efectivo en Caja', 'Deudor'),";
            cuentas += "(5, 11010101, 5, 'Caja General', 'Deudor'),";
            cuentas += "(6, 11010102, 5, 'Caja Chica', 'Deudor'),";
            cuentas += "(7, 110102, 4, 'Efectivo en Bancos', 'Deudor'),";
            cuentas += "(8, 11010201, 5, 'Cuentas Corrientes', 'Deudor'),";
            cuentas += "(9, 11010202, 5, 'Cuestas de Ahorro', 'Deudor'),";
            cuentas += "(10, 11010203, 5, 'Depositos a Plazo', 'Deudor'),";
            cuentas += "(11, 110103, 4, 'Otros Medios Liquidos', 'Deudor'),";
            cuentas += "(12, 1102, 3, 'INVERSIONES TEMPORALES', 'Deudor'),";
            cuentas += "(13, 110201, 4, 'Depositos a Plazo', 'Deudor'),";
            cuentas += "(14, 110202, 4, 'Acciones', 'Deudor'),";
            cuentas += "(15, 110203, 4, 'Bonos', 'Deudor'),";
            cuentas += "(16, 110204, 4, 'Certificados de Inversion', 'Deudor'),";
            cuentas += "(17, 110205, 4, 'Reportos', 'Deudor'),";
            cuentas += "(18, 110299, 4, 'Otros titulos valores', 'Deudor'),";
            cuentas += "(19, 1103, 3, 'CUENTAS Y DOCUMENTOS POR COBRAR', 'Deudor'),";
            cuentas += "(20, 110301, 4, 'Clientes', 'Deudor'),";
            cuentas += "(21, 110302, 4, 'Documentos por cobrar', 'Deudor'),";
            cuentas += "(22, 11030201, 5, 'Pagares', 'Deudor'),";
            cuentas += "(23, 11030202, 5, 'Letras de cambio', 'Deudor'),";
            cuentas += "(24, 110303, 4, 'Prestamos y Anticipos a Empleados', 'Deudor'),";
            cuentas += "(25, 11030301, 5, 'Prestamos', 'Deudor'),";
            cuentas += "(26, 11030302, 5, 'Anticipos', 'Deudor'),";
            cuentas += "(27, 110304, 4, 'Cuentas y Documentos por Cobrar a Accionistas', 'Deudor'),";
            cuentas += "(28, 110305, 4, 'Prestamos a Empresas Relacionadas', 'Deudor'),";
            cuentas += "(29, 110306, 4, 'Otras cuentas por cobrar', 'Deudor'),";
            cuentas += "(30, 11030601, 5, 'Cheques rechazados', 'Deudor'),";
            cuentas += "(31, 11030602, 5, 'Intereses por Cobrar', 'Deudor'),";
            cuentas += "(32, 11030603, 5, 'Dividendos por Cobrar', 'Deudor'),";
            cuentas += "(33, 11030604, 5, 'Anticipos a Proveedores', 'Deudor'),";
            cuentas += "(34, 11030605, 5, 'Deudores varios', 'Deudor'),";
            cuentas += "(35, 1104, 3, 'ARRENDAMIENTOS FINANCIEROS POR COBRAR', 'Deudor'),";
            cuentas += "(36, 110401, 4, 'Arrendamientos Financieros por cobrar', 'Deudor'),";
            cuentas += "(37, 1106, 3, 'IMPUESTOS POR RECUPERAR', 'Deudor'),";
            cuentas += "(38, 110601, 4, 'Credito Fiscal IVA', 'Deudor'),";
            cuentas += "(39, 110602, 4, 'Percepciones y retenciones de IVA', 'Deudor'),";
            cuentas += "(40, 110603, 4, 'Pago a Cuenta del Impuesto sobre la Renta', 'Deudor'),";
            cuentas += "(41, 1107, 3, 'INVENTARIOS', 'Deudor'),";
            cuentas += "(42, 110701, 4, 'Inventarios de Mercaderia', 'Deudor'),";
            cuentas += "(43, 1108, 3, 'PAGOS ANTICIPADOS', 'Deudor'),";
            cuentas += "(44, 110801, 4, 'Seguros', 'Deudor'),";
            cuentas += "(45, 110802, 4, 'Alquileres', 'Deudor'),";
            cuentas += "(46, 110803, 4, 'Papeleria y utiles', 'Deudor'),";
            cuentas += "(47, 110804, 4, 'Impuestos Municipales', 'Deudor'),";
            cuentas += "(48, 110805, 4, 'Publicidad', 'Deudor'),";
            cuentas += "(49, 110899, 4, 'Otros', 'Deudor'),";
            cuentas += "(50, 1109, 3, 'DEPOSITOS EN GARANTIA', 'Deudor'),";
            cuentas += "(51, 12, 2, 'ACTIVO NO CORRIENTE', 'Deudor'),";
            cuentas += "(52, 1201, 3, 'PROPIEDAD, PLANTA Y EQUIPO', 'Deudor'),";
            cuentas += "(53, 120101, 4, 'Terrenos', 'Deudor'),";
            cuentas += "(54, 12010101, 5, 'Urbanos al costo', 'Deudor'),";
            cuentas += "(55, 12010102, 5, 'Rústicos al costo', 'Deudor'),";
            cuentas += "(56, 120102, 4, 'Edificaciones', 'Deudor'),";
            cuentas += "(57, 12010201, 5, 'Edificaciones al costo', 'Deudor'),";
            cuentas += "(58, 120103, 4, 'Instalaciones', 'Deudor'),";
            cuentas += "(59, 12030301, 5, 'Instalaciones al costo', 'Deudor'),";
            cuentas += "(60, 120104, 4, 'Mobiliario y Equipo de oficina', 'Deudor'),";
            cuentas += "(61, 12010401, 5, 'Mobiliario y equipo de oficina al costo', 'Deudor'),";
            cuentas += "(62, 120105, 4, 'Mobiliario y Equipo de Ventas', 'Deudor'),";
            cuentas += "(63, 12010501, 5, 'Mobiliario y equipo de ventas al costo', 'Deudor'),";
            cuentas += "(64, 120106, 4, 'Equipo de Transporte', 'Deudor'),";
            cuentas += "(65, 12010601, 5, 'Equipo de Transporte al costo', 'Deudor'),";
            cuentas += "(66, 120107, 4, 'Herramientas', 'Deudor'),";
            cuentas += "(67, 12010701, 5, 'Herramientas al Costo', 'Deudor'),";
            cuentas += "(68, 120198, 4, 'Depreciación Acumulada de Propiedad Planta y Equipo', 'Deudor'),";
            cuentas += "(69, 12019801, 5, 'Edificaciones', 'Deudor'),";
            cuentas += "(70, 12019802, 5, 'Instalaciones', 'Deudor'),";
            cuentas += "(71, 12019803, 5, 'Mobiliario y Equipo de Oficina', 'Deudor'),";
            cuentas += "(72, 12019804, 5, 'Mobiliario y Equipo de Ventas', 'Deudor'),";
            cuentas += "(73, 12019805, 5, 'Equipo de Transporte', 'Deudor'),";
            cuentas += "(74, 12019806, 5, 'Herramientas', 'Deudor'),";
            cuentas += "(75, 120199, 4, 'Deterioro del Valor de la Propiedad Planta y Equipo', 'Deudor'),";
            cuentas += "(76, 12019901, 5, 'Terrenos', 'Deudor'),";
            cuentas += "(77, 12019902, 5, 'Edificaciones', 'Deudor'),";
            cuentas += "(78, 12019903, 5, 'Instalaciones', 'Deudor'),";
            cuentas += "(79, 12019904, 5, 'Mobiliario y Equipo de Oficina', 'Deudor'),";
            cuentas += "(80, 12019905, 5, 'Mobiliario y Equipo de Ventas', 'Deudor'),";
            cuentas += "(81, 12019906, 5, 'Equipo de Transporte', 'Deudor'),";
            cuentas += "(82, 12019907, 5, 'Herramientas', 'Deudor'),";
            cuentas += "(83, 1202, 3, 'PROPIEDADES DE INVERSION', 'Deudor'),";
            cuentas += "(84, 120201, 4, 'Terrenos', 'Deudor'),";
            cuentas += "(85, 12020101, 5, 'Terrenos al costo', 'Deudor'),";
            cuentas += "(86, 120202, 4, 'Edificaciones', 'Deudor'),";
            cuentas += "(87, 12020201, 5, 'Edificaciones al Costo', 'Deudor'),";
            cuentas += "(88, 120298, 4, 'Depreciación Acumulada de Propiedades de Inversión', 'Deudor'),";
            cuentas += "(89, 12029801, 5, 'Edificaciones', 'Deudor'),";
            cuentas += "(90, 120299, 4, 'Deterioro del Valor de la Propiedades de Inversión', 'Deudor'),";
            cuentas += "(91, 12029901, 5, 'Terrenos', 'Deudor'),";
            cuentas += "(92, 12029902, 5, 'Edificaciones', 'Deudor'),";
            cuentas += "(93, 1203, 3, 'ACTIVOS INTANGIBLES', 'Deudor'),";
            cuentas += "(94, 120301, 4, 'Programas de computación y aplicaciones informáticas', 'Deudor'),";
            cuentas += "(95, 120302, 4, 'Patentes y Marcas', 'Deudor'),";
            cuentas += "(96, 120303, 4, 'Concesiones y franquicias', 'Deudor'),";
            cuentas += "(97, 120304, 4, 'Crédito Mercantil o Derecho de Llave', 'Deudor'),";
            cuentas += "(98, 120398, 4, 'Amortización Acumulada de Intangibles', 'Deudor'),";
            cuentas += "(99, 12039801, 5, 'Programas de computación y aplicaciones Informáticas', 'Deudor'),";
            cuentas += "(100, 12039802, 5, 'Patentes y Marcas', 'Deudor'),";
            cuentas += "(101, 12039803, 5, 'Concesiones y franquicias', 'Deudor'),";
            cuentas += "(102, 12039804, 5, 'Crédito Mercantil o Derecho de Llave', 'Deudor'),";
            cuentas += "(103, 120399, 4, 'Deterioro del Valor de Activos Intangibles', 'Deudor'),";
            cuentas += "(104, 12039901, 5, 'Programas de computación y aplicaciones Informáticas', 'Deudor'),";
            cuentas += "(105, 12039902, 5, 'Patentes y Marcas', 'Deudor'),";
            cuentas += "(106, 12039903, 5, 'Concesiones y franquicias', 'Deudor'),";
            cuentas += "(107, 12039904, 5, 'Crédito Mercantil o Derecho de Llave', 'Deudor'),";
            cuentas += "(108, 1204, 3, 'INVERSIONES PERMANENTES', 'Deudor'),";
            cuentas += "(109, 120401, 4, 'Acciones', 'Deudor'),";
            cuentas += "(110, 120402, 4, 'Bonos', 'Deudor'),";
            cuentas += "(111, 120403, 4, 'Certificados de Inversión', 'Deudor'),";
            cuentas += "(112, 120404, 4, 'Cédulas Hipotecarias', 'Deudor'),";
            cuentas += "(113, 120499, 4, 'Deterioro del Valor de las Inversiones Permanentes', 'Deudor'),";
            cuentas += "(114, 12049901, 5, 'Acciones', 'Deudor'),";
            cuentas += "(115, 12049902, 5, 'Bonos', 'Deudor'),";
            cuentas += "(116, 12069903, 5, 'Certificados de Inversión', 'Deudor'),";
            cuentas += "(117, 12069904, 5, 'Cédulas Hipotecarias', 'Deudor'),";
            cuentas += "(118, 1205, 3, 'DEPOSITOS EN GARANTIA', 'Deudor'),";
            cuentas += "(119, 1206, 3, 'CUENTAS Y DOCUMENTOS POR COBRAR A LARGO PLAZO', 'Deudor'),";
            cuentas += "(120, 120601, 4, 'Clientes', 'Deudor'),";
            cuentas += "(121, 120602, 4, 'Documentos por cobrar', 'Deudor'),";
            cuentas += "(122, 120603, 4, 'Otras cuentas que cobrar a largo plazo', 'Deudor'),";
            cuentas += "(123, 1207, 3, 'ARRENDAMIENTOS FINANCIEROS POR COBRAR A LARGO PLAZO', 'Deudor'),";
            cuentas += "(124, 1208, 3, 'ESTIMACION PARA CUENTAS INCOBRABLES A LARGO PLAZO', 'Deudor'),";
            cuentas += "(125, 1209, 3, 'CONSTRUCCIONES EN PROCESO', 'Deudor'),";
            cuentas += "(126, 1210, 3, 'ACTIVO POR IMPUESTO SOBRE LA RENTA DIFERIDO', 'Deudor'),";
            cuentas += "(127, 2, 1, 'PASIVO', 'Acreedor'),";
            cuentas += "(128, 21, 2, 'PASIVOS CORRIENTES', 'Acreedor'),";
            cuentas += "(129, 2101, 3, 'PRESTAMOS Y SOBREGIROS BANCARIOS', 'Acreedor'),";
            cuentas += "(130, 210101, 4, 'Sobregiros Bancarios', 'Acreedor'),";
            cuentas += "(131, 210102, 4, 'Prestamos Bancarios a corto plazo', 'Acreedor'),";
            cuentas += "(132, 210103, 4, 'Porción circulante de prestamos a Largo Plazo', 'Acreedor'),";
            cuentas += "(133, 210199, 4, 'Otros Prestamos', 'Acreedor'),";
            cuentas += "(134, 2102, 3, 'PROVEEDORES', 'Acreedor'),";
            cuentas += "(135, 210201, 4, 'Locales', 'Acreedor'),";
            cuentas += "(136, 210102, 4, 'Del Exterior', 'Acreedor'),";
            cuentas += "(137, 2103, 3, 'CUENTAS Y DOCUMENTOS POR PAGAR', 'Acreedor'),";
            cuentas += "(138, 210301, 4, 'Acreedores Varios', 'Acreedor'),";
            cuentas += "(139, 210302, 4, 'Cuentas por Pagar a Accionistas', 'Acreedor'),";
            cuentas += "(140, 21030201, 5, 'Préstamos', 'Acreedor'),";
            cuentas += "(141, 21030299, 5, 'Otras Cuentas por Pagar a Accionistas', 'Acreedor'),";
            cuentas += "(142, 210303, 4, 'Dividendos por Pagar', 'Acreedor'),";
            cuentas += "(143, 2104, 3, 'ANTICIPOS POR LIQUIDAR', 'Acreedor'),";
            cuentas += "(144, 210401, 4, 'Por Ventas', 'Acreedor'),";
            cuentas += "(145, 210402, 4, 'Por servicios', 'Acreedor'),";
            cuentas += "(146, 2105, 3, 'RETENCIONES Y DESCUENTOS', 'Acreedor'),";
            cuentas += "(147, 210501, 4, 'Cotización al ISSS Salud', 'Acreedor'),";
            cuentas += "(148, 210502, 4, 'Cotización al ISSS Pensiones', 'Acreedor'),";
            cuentas += "(149, 210503, 4, 'AFP Crecer', 'Acreedor'),";
            cuentas += "(150, 210504, 4, 'AFP Confía', 'Acreedor'),";
            cuentas += "(151, 210505, 4, 'IPSFA', 'Acreedor'),";
            cuentas += "(152, 210506, 4, 'Ordenes de descuento bancario y otras instituciones', 'Acreedor'),";
            cuentas += "(153, 210507, 4, 'FSV-Financiamiento', 'Acreedor'),";
            cuentas += "(154, 210508, 4, 'Procuraría y otras ordenes de descuento', 'Acreedor'),";
            cuentas += "(155, 210509, 4, 'Retenciones Renta', 'Acreedor'),";
            cuentas += "(156, 210599, 4, 'Otras retenciones', 'Acreedor'),";
            cuentas += "(157, 2106, 3, 'BENEFICIO A EMPLEADOS POR PAGAR', 'Acreedor'),";
            cuentas += "(158, 210601, 4, 'Sueldos por pagar', 'Acreedor'),";
            cuentas += "(159, 210602, 4, 'Comisiones por pagar', 'Acreedor'),";
            cuentas += "(160, 210603, 4, 'Bonificaciones por pagar', 'Acreedor'),";
            cuentas += "(161, 210604, 4, 'Vacaciones acumuladas por pagar', 'Acreedor'),";
            cuentas += "(162, 210605, 4, 'Aguinaldos por pagar', 'Acreedor'),";
            cuentas += "(163, 210606, 4, 'Aporte patronal ISSS', 'Acreedor'),";
            cuentas += "(164, 210607, 4, 'Aporte patronal AFP', 'Acreedor'),";
            cuentas += "(165, 210699, 4, 'Otros beneficios a empleados por pagar', 'Acreedor'),";
            cuentas += "(166, 2107, 3, 'IMPUESTO POR PAGAR', 'Acreedor'),";
            cuentas += "(167, 210701, 4, 'IVA por pagar', 'Acreedor'),";
            cuentas += "(168, 210702, 4, 'Debito Fiscal IVA', 'Acreedor'),";
            cuentas += "(169, 21070201, 5, 'Por Ventas de Comprobantes de Credito Fiscal', 'Acreedor'),";
            cuentas += "(170, 21070202, 5, 'Por Ventas con Factura', 'Acreedor'),";
            cuentas += "(171, 210703, 4, 'Pago a Cuenta por Pagar', 'Acreedor'),";
            cuentas += "(172, 210704, 4, 'Impuestos Municipales', 'Acreedor'),";
            cuentas += "(173, 210705, 4, 'Impuesto Sobre la Renta por Pagar', 'Acreedor'),";
            cuentas += "(174, 2108, 3, 'OBLIGACIONES BAJO ARRENDAMIENTO FINANCIERO', 'Acreedor'),";
            cuentas += "(175, 210801, 4, 'Arrendamiento financiero por pagar a corto plazo', 'Acreedor'),";
            cuentas += "(176, 22, 2, 'PASIVO NO CORRIENTE', 'Acreedor'),";
            cuentas += "(177, 2201, 3, 'CUENTAS Y DOCUMENTOS POR PAGAR A LARGO PLAZO', 'Acreedor'),";
            cuentas += "(178, 220101, 4, 'Proveedores', 'Acreedor'),";
            cuentas += "(179, 220102, 4, 'Acreedores Varios', 'Acreedor'),";
            cuentas += "(180, 2202, 3, 'PRESTAMOS A LARGO PLAZO', 'Acreedor'),";
            cuentas += "(181, 220299, 4, 'Otros Prestamos', 'Acreedor'),";
            cuentas += "(182, 2203, 3, 'OBLIGACIONES BAJO ARRENDAMIENTO FINANCIERO A LARGO PLAZO', 'Acreedor'),";
            cuentas += "(183, 2204, 3, 'PASIVO POR IMPUESTO SOBRE LA RENTA DIFERIDO', 'Acreedor'),";
            cuentas += "(184, 2205, 3, 'ESTIMACION PARA OBLIGACIONES LABORALES', 'Acreedor'),";
            cuentas += "(185, 220501, 4, 'Beneficios por Terminacion de Contrato por Pagar', 'Acreedor'),";
            cuentas += "(186, 3, 1, 'Patrimonio', 'Acreedor'),";
            cuentas += "(187, 31, 2, 'CAPITAL CONTABLE', 'Acreedor'),";
            cuentas += "(188, 3101, 3, 'Capital Social', 'Acreedor'),";
            cuentas += "(189, 310101, 4, 'Capital Social Minimo', 'Acreedor'),";
            cuentas += "(190, 310102, 4, 'Capital Social Variable', 'Acreedor'),";
            cuentas += "(191, 3102, 3, 'RESERVA LEGAL', 'Acreedor'),";
            cuentas += "(192, 3103, 3, 'UTILIDADES ACUMULADAS', 'Acreedor'),";
            cuentas += "(193, 310301, 4, 'Del Presente Ejercicio', 'Acreedor'),";
            cuentas += "(194, 310302, 4, 'De Ejercicios Anteriores', 'Acreedor'),";
            cuentas += "(195, 3104, 3, 'PERDIDAS ACUMULADAS', 'Acreedor'),";
            cuentas += "(196, 4, 1, 'CUENTAS DE RESULTADOS DEUDORAS', 'Deudor'),";
            cuentas += "(197, 41, 2, 'COSTOS', 'Deudor'),";
            cuentas += "(198, 4101, 3, 'COSTOS DE VENTA', 'Deudor'),";
            cuentas += "(199, 4102, 3, 'COMPRAS', 'Deudor'),";
            cuentas += "(200, 410201, 4, 'Inventarios para la venta', 'Deudor'),";
            cuentas += "(201, 4103, 3, 'GASTOS SOBRE COMPRAS', 'Deudor'),";
            cuentas += "(202, 42, 2, 'GASTOS DE OPERACION', 'Deudor'),";
            cuentas += "(203, 4201, 3, 'GASTOS DE VENTAS Y SERVICIOS', 'Deudor'),";
            cuentas += "(204, 420101, 4, 'Sueldos y salarios', 'Deudor'),";
            cuentas += "(205, 410102, 4, 'Horas extras', 'Deudor'),";
            cuentas += "(206, 410103, 4, 'Comisiones sobre ventas', 'Deudor'),";
            cuentas += "(207, 410104, 4, 'Aguinaldos', 'Deudor'),";
            cuentas += "(208, 420105, 4, 'Vacaciones', 'Deudor'),";
            cuentas += "(209, 420106, 4, 'Bonificaciones y gratificaciones', 'Deudor'),";
            cuentas += "(210, 420107, 4, 'Indemnizaciones', 'Deudor'),";
            cuentas += "(211, 420110, 4, 'Insafort', 'Deudor'),";
            cuentas += "(212, 420111, 4, 'Viaticos y Transporte', 'Deudor'),";
            cuentas += "(213, 420112, 4, 'Atencion a Empleados', 'Deudor'),";
            cuentas += "(214, 420113, 4, 'Honorarios', 'Deudor'),";
            cuentas += "(215, 420114, 4, 'Alquileres', 'Deudor'),";
            cuentas += "(216, 420115, 4, 'Energia Electrica', 'Deudor'),";
            cuentas += "(217, 420116, 4, 'Comunicaciones', 'Deudor'),";
            cuentas += "(218, 420117, 4, 'Servicio de agua', 'Deudor'),";
            cuentas += "(219, 420118, 4, 'Papeleria y utiles', 'Deudor'),";
            cuentas += "(220, 420119, 4, 'Impuestos municipales', 'Deudor'),";
            cuentas += "(221, 420120, 4, 'Fletes y transporte', 'Deudor'),";
            cuentas += "(222, 420121, 4, 'Correos y encomiendas', 'Deudor'),";
            cuentas += "(223, 420122, 4, 'Publicidad y regalias a clientes', 'Deudor'),";
            cuentas += "(224, 420123, 4, 'Capacitacion a empleados', 'Deudor'),";
            cuentas += "(225, 420124, 4, 'Uniformes', 'Deudor'),";
            cuentas += "(226, 420125, 4, 'Mantenimiento de edificio e instalaciones', 'Deudor'),";
            cuentas += "(227, 420126, 4, 'Mantenimiento de equipo de transporte', 'Deudor'),";
            cuentas += "(228, 420127, 4, 'Mantenimiento de mobiliario y equipo', 'Deudor'),";
            cuentas += "(229, 420128, 4, 'Matriculas de circulacion de vehiculo', 'Deudor'),";
            cuentas += "(230, 420129, 4, 'Depreciaciones', 'Deudor'),";
            cuentas += "(231, 420130, 4, 'Cuentas incobrables', 'Deudor'),";
            cuentas += "(232, 420131, 4, 'Articulos de limpieza y aseo', 'Deudor'),";
            cuentas += "(233, 420132, 4, 'Seguros sobre riesgos', 'Deudor'),";
            cuentas += "(234, 420133, 4, 'Vigilancia', 'Deudor'),";
            cuentas += "(235, 420134, 4, 'Combustible y lubricantes', 'Deudor'),";
            cuentas += "(236, 420137, 4, 'Atencion a Clientes', 'Deudor'),";
            cuentas += "(237, 420199, 4, 'Otros', 'Deudor'),";
            cuentas += "(238, 4202, 3, 'GASTOS DE ADMINISTRACION', 'Deudor'),";
            cuentas += "(239, 420201, 4, 'Sueldos y salarios', 'Deudor'),";
            cuentas += "(240, 420202, 4, 'Horas extras', 'Deudor'),";
            cuentas += "(241, 420203, 4, 'Aguinaldos', 'Deudor'),";
            cuentas += "(242, 420104, 4, 'Vacaciones', 'Deudor'),";
            cuentas += "(243, 420105, 4, 'Bonificaciones', 'Deudor'),";
            cuentas += "(244, 420212, 4, 'Honorarios Profesionales', 'Deudor'),";
            cuentas += "(245, 420213, 4, 'Alquileres', 'Deudor'),";
            cuentas += "(246, 420214, 4, 'Energia electrica', 'Deudor'),";
            cuentas += "(247, 420215, 4, 'Comunicaciones', 'Deudor'),";
            cuentas += "(248, 420216, 4, 'Correo y encomiendas', 'Deudor'),";
            cuentas += "(249, 420217, 4, 'Servicio de Agua', 'Deudor'),";
            cuentas += "(250, 420218, 4, 'Papeleria y utiles', 'Deudor'),";
            cuentas += "(251, 420219, 4, 'Impuestos municipales', 'Deudor'),";
            cuentas += "(252, 420222, 4, 'Mantenimiento de equipo de oficina', 'Deudor'),";
            cuentas += "(253, 420223, 4, 'Mantenimiento de vehiculos', 'Deudor'),";
            cuentas += "(254, 420224, 4, 'Mantenimiento de edificaciones e instalaciones', 'Deudor'),";
            cuentas += "(255, 420225, 4, 'Matriculas de circulacion de vehiculos', 'Deudor'),";
            cuentas += "(256, 420226, 4, 'Matriculas de comercio', 'Deudor'),";
            cuentas += "(257, 420227, 4, 'Depreciaciones', 'Deudor'),";
            cuentas += "(258, 420228, 4, 'Limpieza y aseo', 'Deudor'),";
            cuentas += "(259, 420229, 4, 'Seguros sobre riesgos', 'Deudor'),";
            cuentas += "(260, 420230, 4, 'Vigilacia', 'Deudor'),";
            cuentas += "(261, 420231, 4, 'Suscripciones y cuotas', 'Deudor'),";
            cuentas += "(262, 420233, 4, 'Fovial', 'Deudor'),";
            cuentas += "(263, 420234, 4, 'Cotrans', 'Deudor'),";
            cuentas += "(264, 420299, 4, 'Otros', 'Deudor'),";
            cuentas += "(265, 4203, 3, 'GASTOS POR DETERIORO', 'Deudor'),";
            cuentas += "(266, 420301, 4, 'Deterioro del Valor de los Inventarios', 'Deudor'),";
            cuentas += "(267, 420302, 4, 'Deterioro del Valor de la Propiedad Planta y Equipo', 'Deudor'),";
            cuentas += "(268, 420303, 4, 'Deterioros del Valor de las Propiedades de Inversion', 'Deudor'),";
            cuentas += "(269, 420304, 4, 'Deterioro del Valor de Activos Intangibles', 'Deudor'),";
            cuentas += "(270, 420305, 4, 'Deterioro de las Inversiones Permanentes', 'Deudor'),";
            cuentas += "(271, 4204, 3, 'GASTOS POR IMPUESTOS SOBRE RENTA', 'Deudor'),";
            cuentas += "(272, 420401, 4, 'Gastos por impuestos sobre la renta corriente', 'Deudor'),";
            cuentas += "(273, 420402, 4, 'Gastos por impuestos sobre la renta diferido', 'Deudor'),";
            cuentas += "(274, 43, 2, 'GASTOS NO OPERATIVOS', 'Deudor'),";
            cuentas += "(275, 4301, 3, 'GASTOS FINANCIEROS', 'Deudor'),";
            cuentas += "(276, 430101, 4, 'Intereses', 'Deudor'),";
            cuentas += "(277, 430102, 4, 'Comiciones financieras', 'Deudor'),";
            cuentas += "(278, 430103, 4, 'Seguros finanieros', 'Deudor'),";
            cuentas += "(279, 430104, 4, 'Honorarios financieros', 'Deudor'),";
            cuentas += "(280, 420399, 4, 'Otros', 'Deudor'),";
            cuentas += "(281, 4302, 3, 'OTROS GASTOS', 'Deudor'),";
            cuentas += "(282, 430201, 4, 'Perdida de venta de activo fijo', 'Deudor'),";
            cuentas += "(283, 430299, 4, 'Otros', 'Deudor'),";
            cuentas += "(284, 5, 1, 'CUENTAS DE RESULTADOS ACREEDORAS', 'Acreedor'),";
            cuentas += "(285, 51, 2, 'INGRESOS DE OPERACION', 'Acreedor'),";
            cuentas += "(286, 5101, 3, 'VENTAS', 'Acreedor'),";
            cuentas += "(287, 5102, 3, 'REBAJAS Y DEVOLUCIONES SOBRE VENTAS', 'Acreedor'),";
            cuentas += "(288, 510201, 4, 'Rebajas sobre ventas', 'Acreedor'),";
            cuentas += "(289, 510202, 4, 'Devoluciones sobre ventas', 'Acreedor'),";
            cuentas += "(290, 5103, 3, 'INGRESOS POR SERVICIOS', 'Acreedor'),";
            cuentas += "(291, 510301, 4, 'Mantenimiento de computadoras', 'Acreedor'),";
            cuentas += "(292, 510399, 4, 'Otros', 'Acreedor'),";
            cuentas += "(293, 5104, 3, 'INGRESOS POR REVERSION DEL DETERIORO', 'Acreedor'),";
            cuentas += "(294, 510401, 4, 'Reversion de Deterioro del Valor de los Inventarios', 'Acreedor'),";
            cuentas += "(295, 510402, 4, 'Reversion de Deterioro del Valor de Propiedad Planta y Equipo', 'Acreedor'),";
            cuentas += "(296, 510403, 4, 'Deterioro del Valor de las Propiedades de Inversion', 'Acreedor'),";
            cuentas += "(297, 510404, 4, 'Reversion de Deterioro del Valor de Activos Intagibles', 'Acreedor'),";
            cuentas += "(298, 510405, 4, 'Reversion de Deterioro del Valor de las Inv Permanentes', 'Acreedor'),";
            cuentas += "(299, 52, 2, 'INGRESOS NO OPERATIVOS', 'Acreedor'),";
            cuentas += "(300, 5201, 3, 'OTROS INGRESOS', 'Acreedor'),";
            cuentas += "(301, 520101, 4, 'Intereses Bancarios', 'Acreedor'),";
            cuentas += "(302, 520102, 4, 'Utilidad en venta de activo fijo', 'Acreedor'),";
            cuentas += "(303, 520199, 4, 'Otros', 'Acreedor'),";
            cuentas += "(304, 6, 1, 'CUENTA LIQUIDADORA', 'Acreedor'),";
            cuentas += "(305, 61, 2, 'CUENTA LIQUIDADORA DE RESULTADO', 'Acreedor'),";
            cuentas += "(306, 6101, 3, 'UTILIDADES Y PERDIDAS', 'Acreedor'),";
            cuentas += "(307, 7, 1, 'CUENTAS DE ORDEN', 'Acreedor'),";
            cuentas += "(308, 71, 2, 'CUENTAS DE ORDEN DEUDORAS', 'Acreedor'),";
            cuentas += "(309, 7101, 3, 'CUENTAS DE ORDEN DEUDORAS', 'Acreedor'),";
            cuentas += "(310, 7102, 3, 'CUENTAS DE ORDEN POR CONTRA', 'Acreedor');";

            return cuentas;
        }

    }
}
