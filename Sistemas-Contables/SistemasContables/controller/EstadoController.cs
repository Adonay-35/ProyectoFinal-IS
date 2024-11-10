using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class EstadoController
    {
        private EstadosDAO estadosDAO;

        public EstadoController()
        {
            estadosDAO = new EstadosDAO();
        }

        public List<Estado> getList()
        {
            return estadosDAO.getList();
        }
    }
}
