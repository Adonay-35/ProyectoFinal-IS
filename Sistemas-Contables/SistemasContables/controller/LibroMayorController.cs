using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class LibroMayorController
    {
        private LibroMayorDAO libroMayorDAO;

        public LibroMayorController()
        {
            libroMayorDAO = new LibroMayorDAO();
        }

        public List<string> getListCodigos(int idLibroDiario)
        {
            return libroMayorDAO.getListCodigos(idLibroDiario);
        }

        public Partida getPartida(string nivel3)
        {
            return libroMayorDAO.getPartida(nivel3);
        }

        public List<Partida> getListPartida(string codigo, int idLibroDiario)
        {
            return libroMayorDAO.getListPartida(codigo, idLibroDiario);
        }
    }
}
