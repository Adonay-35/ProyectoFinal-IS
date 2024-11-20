using System;

namespace SistemasContables.Models
{
    public class Rol
    {
        private int idRol;
        private string nombreRol;

        public Rol(int idRol, string descripcion)
        {
            this.idRol = idRol;
            this.nombreRol = descripcion;
        }


        public Rol()
        {
        }

        public int IdRol
        {
            get { return this.idRol; }
            set { this.idRol = value; }
        }

        public string NombreRol
        {
            get { return this.nombreRol; }
            set { this.nombreRol = value; }
        }
    }
}
