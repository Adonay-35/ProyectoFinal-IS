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

        public bool insert(Empleado empleado)
        {
            return empleadosDAO.insert(empleado);
        }

        public bool update(Empleado empleado)
        {
            return empleadosDAO.update(empleado);
        }

        public void delete(int idEmpleado)
        {
            empleadosDAO.delete(idEmpleado);  // Elimina un usuario usando su id
        }

        public Empleado ObtenerEmpleadoPorId(int idEmpleado)
        {
            // Obtiene el usuario con el ID proporcionado y lo retorna
            return empleadosDAO.ObtenerEmpleadoPorId(idEmpleado);
        }
    }
}
