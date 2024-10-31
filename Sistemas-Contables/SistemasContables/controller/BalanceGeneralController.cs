using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    class BalanceGeneralController
    {
        private BalanceGeneralDAO balanceGeneralDAO;

        public BalanceGeneralController()
        {
            balanceGeneralDAO = new BalanceGeneralDAO();
        }

        public List<Cuenta> getListCuentas()
        {
            return balanceGeneralDAO.getListCuentas();
        }

        public List<CuentaPartida> getListSaldos(int idLibroDiario, string numeroLibro)
        {
            return balanceGeneralDAO.getListSaldos(idLibroDiario, numeroLibro);
        }
    }
}
