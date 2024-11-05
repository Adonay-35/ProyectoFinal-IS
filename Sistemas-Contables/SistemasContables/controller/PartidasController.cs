using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class PartidasController
    {
        private PartidasDAO partidasDAO;

        public PartidasController()
        {
            partidasDAO = new PartidasDAO();
        }

        public bool insert(Partida partida)
        {
            return partidasDAO.insert(partida);
        }

        public List<Partida> getList(int idLibroDiario)
        {
            return partidasDAO.getList(idLibroDiario);
        }

        public bool update(Partida partida)
        {
            return partidasDAO.update(partida);
        }

        public void delete(int n_partida, int idLibro)
        {
            partidasDAO.delete(n_partida, idLibro);
        }

        public Partida getPartida(int n_partida, int idLibro)
        {
            return partidasDAO.getPartida(n_partida, idLibro);
        }

        public double total(int idLibro, string campoCalcular)
        {
            return partidasDAO.total(idLibro, campoCalcular);
        }

        public bool VerificarAjusteIVA(int idLibro)
        {
            return partidasDAO.VerificarAjusteIVA(idLibro);
        }

    }
}
