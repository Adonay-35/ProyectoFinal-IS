using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class CuentaPartidaController
    {
        private CuentaPartidaDAO cuentaPartidaDAO;

        public CuentaPartidaController()
        {
            cuentaPartidaDAO = new CuentaPartidaDAO();
        }

        public List<CuentaPartida> getList(int n_partida, int idLibro)
        {
            List<CuentaPartida> lista = cuentaPartidaDAO.getList(n_partida, idLibro);

            return lista;

        }
    }
}
