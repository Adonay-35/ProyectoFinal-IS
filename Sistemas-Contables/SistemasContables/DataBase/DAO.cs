using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.DataBase
{
    public class DAO
    {
        protected SqlConnection conn;

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

        protected const string TABLE_USUARIO = "usuario";
        protected const string ID_USUARIO = "idUsuario";
        protected const string NOMBRE_USUARIO = "nombreUsuario";
        protected const string CLAVE_USUARIO = "claveUsuario";
        protected const string ID_EMPLEADO = "idEmpleado";
        protected const string ID_ROL = "idRol";
        protected const string ID_ESTADO = "idEstado";

        protected const string TABLE_EMPLEADO = "empleado";
        //protected const string ID_EMPLEADO = "idEmpleado";
        protected const string NOMBRES_EMPLEADO = "nombresEmpleado";
        protected const string APELLIDOS_EMPLEADO = "apellidosEmpleado";
        protected const string FECHA_NACIMIENTO = "fechaNacimiento";
        protected const string DUI_EMPLEADO = "duiEmpleado";
        protected const string ISSS_EMPLEADO = "isssEmpleado";
        protected const string TELEFONO = "telefono";
        protected const string CORREO = "correo";
        protected const string LINEA1 = "linea1";
        protected const string LINEA2 = "linea2";
        protected const string CODIGO_POSTAL = "codigoPostal";
        protected const string ID_DEPARTAMENTO = "idDepartamento";
        protected const string ID_MUNICIPIO = "idMunicipio";
        protected const string ID_DISTRITO = "idDistrito";

        protected const string TABLE_ROL = "Roles";
        //protected const string ID_ROL = "idRol";
        protected const string NOMBRE_ROL = "NombreRol";

        protected const string TABLE_ESTADO = "estado";
        //protected const string ID_ESTADO = "idEstado";
        protected const string DESCRIPCION_ESTADO = "descripcionEstado";

        protected const string TABLE_DEPARTAMENTO = "departamento";
        //protected const string ID_DEPARTAMENTO = "idDepartamento";
        protected const string NOMBRE_DEPARTAMENTO = "nombreDepartamento";

        protected const string TABLE_MUNICIPIO = "municipio";
       /// protected const string ID_MUNICIPIO = "idMunicipio";
        protected const string NOMBRE_MUNICIPIO = "nombreMunicipio";
        //protected const string ID_DEPARTAMENTO = "idDepartamento";

        protected const string TABLE_DISTRITO = "distrito";
        //protected const string ID_DISTRITO = "idDistrito";
        protected const string NOMBRE_DISTRITO = "nombreDistrito";
        //protected const string ID_MUNICIPIO = "idMunicipio";;

    }
}
