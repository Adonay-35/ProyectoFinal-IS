using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.Models
{
    public class Cuenta
    {
        private int idCuenta;
        private string nombre;
        private string codigo;
        private int nivel;
        private string tipoSaldo;

        public int IdCuenta
        {
            get
            {
                return this.idCuenta;
            }
            set
            {
                this.idCuenta = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Codigo
        {
            get {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }

        public int Nivel
        {
            get
            {
                return this.nivel;
            }
            set
            {
                this.nivel = value;
            }
        }

        public string TipoSaldo
        {
            get
            {
                return this.tipoSaldo;
            }
            set
            {
                this.tipoSaldo = value;
            }

        }

    }
}
