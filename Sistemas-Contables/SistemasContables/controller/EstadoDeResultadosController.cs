using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class EstadoDeResultadosController
    {
        private EstadoDeResultadosDAO estadoDeResultadosDAO;

        public EstadoDeResultadosController()
        {
            estadoDeResultadosDAO = new EstadoDeResultadosDAO();
        }

        public double getTotalIngresos(int idLibroDiario)
        {
            return estadoDeResultadosDAO.getTotalIngresos(idLibroDiario);
        }

        public double getTotalCostos(int idLibroDiario)
        {
            return estadoDeResultadosDAO.getTotalCostos(idLibroDiario);
        }
        public double getTotalGastos(int idLibroDiario)
        {
            return estadoDeResultadosDAO.getTotalGastos(idLibroDiario);
        }


    }
}