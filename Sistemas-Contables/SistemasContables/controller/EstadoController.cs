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

        public bool insert(Estado estado)
        {
            return estadosDAO.insert(estado);
        }

        public bool update(Estado estado)
        {
            return estadosDAO.update(estado);
        }

        public void delete(int idEstado)
        {
            estadosDAO.delete(idEstado);  // Elimina un usuario usando su id
        }

        public Estado ObtenerEstadoPorId(int idEstado)
        {
            // Obtiene el usuario con el ID proporcionado y lo retorna
            return estadosDAO.ObtenerEstadoPorId(idEstado);
        }


        public Estado ObtenerDescripcionEstado(string descripcionEstado)
        {
            // Obtiene el usuario con el ID proporcionado y lo retorna
            return estadosDAO.ObtenerDescripcionEstado(descripcionEstado);
        }
    }
}
