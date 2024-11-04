using System;

namespace SistemasContables.Models
{
    public class Estado
    {
        private int idEstado;
        private string descripcionEstado;

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
