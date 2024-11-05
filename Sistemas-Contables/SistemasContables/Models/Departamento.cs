using System;

namespace SistemasContables.Models
{
    public class Departamento
    {
        private int idDepartamento;
        private string nombreDepartamento;

        public int IdDepartamento
        {
            get { return this.idDepartamento; }
            set { this.idDepartamento = value; }
        }

        public string NombreDepartamento
        {
            get { return this.nombreDepartamento; }
            set { this.nombreDepartamento = value; }
        }
    }
}
