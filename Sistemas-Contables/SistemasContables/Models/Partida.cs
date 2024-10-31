using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.Models
{
    public class Partida
    {
        private int idPartida;
        private string fecha;
        private string detalle;
        private int n_partida;
        private int idLibro;
        private List<CuentaPartida> listaCuentasPartida;

        public int IdPartida
        {
            get
            {
                return this.idPartida;
            }
            set
            {
                this.idPartida = value;
            }
        }

        public string Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        public string Detalle
        {
            get
            {
                return this.detalle;
            }
            set
            {
                this.detalle = value;
            }
        }

        public int N_Partida
        {
            get
            {
                return this.n_partida;
            }
            set
            {
                this.n_partida = value;
            }
        }

        public int IdLibro
        {
            get
            {
                return this.idLibro;
            }
            set
            {
                this.idLibro = value;
            }
        }

        public List<CuentaPartida> ListaCuentasPartida
        {
            get
            {
                return this.listaCuentasPartida;
            }
            set
            {
                this.listaCuentasPartida = value;
            }
        }

    }
}
