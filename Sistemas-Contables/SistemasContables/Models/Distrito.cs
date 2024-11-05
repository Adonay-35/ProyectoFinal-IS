using System;

namespace SistemasContables.Models
{
    public class Distrito
    {
        private int idDistrito;
        private string nombreDistrito;
        private int idMunicipio;

        public int IdDistrito
        {
            get { return this.idDistrito; }
            set { this.idDistrito = value; }
        }

        public string NombreDistrito
        {
            get { return this.nombreDistrito; }
            set { this.nombreDistrito = value; }
        }

        public int IdMunicipio
        {
            get { return this.idMunicipio; }
            set { this.idMunicipio = value; }
        }
    }
}
