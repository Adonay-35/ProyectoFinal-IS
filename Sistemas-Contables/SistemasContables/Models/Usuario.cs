using System;

namespace SistemasContables.Models
{
    public class Usuario
    {
        private int idUsuario;
        private string nombreUsuario;
        private string claveUsuario;
        private int idEmpleado;
        private int idRol;
        private int idEstado;

        public int IdUsuario
        {
            get
            {
                return this.idUsuario;
            }
            set
            {
                this.idUsuario = value;
            }
        }

        public string NombreUsuario
        {
            get
            {
                return this.nombreUsuario;
            }
            set
            {
                this.nombreUsuario = value;
            }
        }

        public string ClaveUsuario
        {
            get
            {
                return this.claveUsuario;
            }
            set
            {
                this.claveUsuario = value;
            }
        }

        public int IdEmpleado
        {
            get
            {
                return this.idEmpleado;
            }
            set
            {
                this.idEmpleado = value;
            }
        }

        public int IdRol
        {
            get
            {
                return this.idRol;
            }
            set
            {
                this.idRol = value;
            }
        }

        public int IdEstado
        {
            get
            {
                return this.idEstado;
            }
            set
            {
                this.idEstado = value;
            }
        }
    }
}
