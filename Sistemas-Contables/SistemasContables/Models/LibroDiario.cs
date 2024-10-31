using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.Models
{
    public class LibroDiario
    {
        private int idLibroDiario;
        private string periodo;

        public int IdLibroDiario
        {
            get
            {
                return this.idLibroDiario;
            }
            set
            {
                this.idLibroDiario = value;
            }
        }

        public string Periodo
        {
            get
            {
                return this.periodo;
            }
            set
            {
                this.periodo = value;
            }
        }
    }
}
