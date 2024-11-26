using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    class ReportesController
    {
        private ReportesDAO reportesDAO;

        public ReportesController()
        {
            reportesDAO = new ReportesDAO();
        }

        //Para el reporte de ventas
        public List<string> getListCodigos(int idLibroDiario)
        {
            return reportesDAO.getListCodigos(idLibroDiario);
        }

        public Partida getPartida(string nivel3)
        {
            return reportesDAO.getPartida(nivel3);
        }

        public List<Partida> getListPartida(string codigo, int idLibroDiario)
        {
            return reportesDAO.getListPartida(codigo, idLibroDiario);
        }
    }
}
