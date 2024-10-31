using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables
{
    public class CuentasController
    {
        private CuentasDAO cuentasDAO;
        private List<Cuenta> lista;

        public CuentasController()
        {
            this.cuentasDAO = new CuentasDAO();
        }

        public List<Cuenta> getList()
        {
            this.lista = this.cuentasDAO.getList();

            return this.lista;
        }

    }
}
