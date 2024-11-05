using System;

namespace SistemasContables.Models
{
    public class Direccion
    {
        private int idDireccion;
        private string linea1;
        private string linea2;
        private string codigoPostal;
        private int idDistrito;

        public int IdDireccion
        {
            get { return this.idDireccion; }
            set { this.idDireccion = value; }
        }

        public string Linea1
        {
            get { return this.linea1; }
            set { this.linea1 = value; }
        }

        public string Linea2
        {
            get { return this.linea2; }
            set { this.linea2 = value; }
        }

        public string CodigoPostal
        {
            get { return this.codigoPostal; }
            set { this.codigoPostal = value; }
        }

        public int IdDistrito
        {
            get { return this.idDistrito; }
            set { this.idDistrito = value; }
        }
    }
}
