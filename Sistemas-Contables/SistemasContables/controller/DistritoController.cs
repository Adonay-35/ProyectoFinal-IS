using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    internal class DistritoController
    {
        private DistritosDAO distritoDAO;

        public DistritoController()
        {
            distritoDAO = new DistritosDAO();
        }

        public List<Distrito> getList()
        {
            return distritoDAO.getList();
        }
    }
}
