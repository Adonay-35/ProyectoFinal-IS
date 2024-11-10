using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class EmpleadoController
    {
        private EmpleadosDAO empleadosDAO;

        public EmpleadoController()
        {
            empleadosDAO = new EmpleadosDAO();
        }

        public List<Empleado> getList()
        {
            return empleadosDAO.getList();
        }
    }
}
