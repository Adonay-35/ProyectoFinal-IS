using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class DireccionesController
    {
        private DireccionesDAO direccionesDAO;

        public DireccionesController()
        {
            direccionesDAO = new DireccionesDAO();
        }

        public List<Direccion> getList()
        {
            return direccionesDAO.getList();
        }

        public bool insert(Direccion direccion)
        {
            return direccionesDAO.insert(direccion);
        }

        public bool update(Direccion direccion)
        {
            return direccionesDAO.update(direccion);
        }

        public void delete(int idDireccion)
        {
            direccionesDAO.delete(idDireccion);
        }

        public Direccion ObtenerDireccionPorId(int idDireccion)
        {
            return direccionesDAO.ObtenerDireccionPorId(idDireccion);
        }
    }
}
