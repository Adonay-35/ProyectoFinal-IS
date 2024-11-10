using System;

namespace SistemasContables.Models
{
    public class Estado
    {
        private int idEstado;
        private string descripcionEstado;

        public Estado(int idEstado, string descripcion)
        {
            this.idEstado = idEstado;
            this.descripcionEstado = descripcion;
        }

        public Estado()
        {
        }

        public int IdEstado
        {
            get { return this.idEstado; }
            set { this.idEstado = value; }
        }

        public string DescripcionEstado
        {
            get { return this.descripcionEstado; }
            set { this.descripcionEstado = value; }
        }
    }
}
