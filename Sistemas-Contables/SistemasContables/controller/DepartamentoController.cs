using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    internal class DepartamentoController
    {
        private DepartamentosDAO departamentoDAO;

        public DepartamentoController()
        {
            departamentoDAO = new DepartamentosDAO();
        }

        public List<Departamento> getList()
        {
            return departamentoDAO.getList();
        }
    }
}
