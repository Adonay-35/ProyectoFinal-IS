using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

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

    
        
    }
}
