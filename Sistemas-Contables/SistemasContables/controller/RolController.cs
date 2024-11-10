using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class RolController
    {
        private RolesDAO rolesDAO;

        public RolController()
        {
            rolesDAO = new RolesDAO();
        }

        public List<Rol> getList()
        {
            return rolesDAO.getList();
        }


    }
}
