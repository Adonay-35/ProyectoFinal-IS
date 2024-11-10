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

        public bool insert(Rol rol)
        {
            return rolesDAO.insert(rol);
        }

        public bool update(Rol rol)
        {
            return rolesDAO.update(rol);
        }

        public void delete(int idRol)
        {
            rolesDAO.delete(idRol);  // Elimina un usuario usando su id
        }

        public Rol ObtenerRolPorId(int idRol)
        {
            // Obtiene el usuario con el ID proporcionado y lo retorna
            return rolesDAO.ObtenerRolPorId(idRol);
        }
    }
}
