using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    internal class MunicipioController
    {
        private MunicipiosDAO municipioDAO;

        public MunicipioController()
        {
            municipioDAO = new MunicipiosDAO();
        }

        public List<Municipio> getList()
        {
            return municipioDAO.getList();
        }
    }
}
