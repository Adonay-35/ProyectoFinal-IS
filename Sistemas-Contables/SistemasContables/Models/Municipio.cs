using System;

namespace SistemasContables.Models
{
    public class Municipio
    {
        private int idMunicipio;
        private string nombreMunicipio;
        private int idDepartamento;

        public Municipio(int idmunicipio, string municipio)
        {
            this.idMunicipio = idmunicipio;
            this.nombreMunicipio = municipio;
        }

        public Municipio()
        {
        }


        public int IdMunicipio
        {
            get { return this.idMunicipio; }
            set { this.idMunicipio = value; }
        }

        public string NombreMunicipio
        {
            get { return this.nombreMunicipio; }
            set { this.nombreMunicipio = value; }
        }

        public int IdDepartamento
        {
            get { return this.idDepartamento; }
            set { this.idDepartamento = value; }
        }
    }
}
