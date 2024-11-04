using System;

namespace SistemasContables.Models
{
    public class Rol
    {
        private int idRol;
        private string nombreRol;

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
