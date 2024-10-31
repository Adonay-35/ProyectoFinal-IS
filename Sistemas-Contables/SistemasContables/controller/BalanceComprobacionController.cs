using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class BalanceComprobacionController
    {
        private BalanceComprobacionDAO balanceComprobacionDAO;

        public BalanceComprobacionController()
        {
            balanceComprobacionDAO = new BalanceComprobacionDAO();
        }

        public List<CuentaPartida> getListCuentas()
        {
            return balanceComprobacionDAO.getListCuentas();
        }

        public List<CuentaPartida> getListCuentasPartidas(string codigo, int idLibroDiario)
        {
            return balanceComprobacionDAO.getListCuentasPartidas(codigo, idLibroDiario);
        }

     }
}
