using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    internal class UsuarioController
    {
        private UsuariosDAO usuariosDAO;

        public UsuarioController()
        {
            usuariosDAO = new UsuariosDAO();
        }

        public bool Login(string nombreUsuario, string claveUsuario)
        {
            // Obtiene el usuario con el nombre proporcionado
            Usuario usuario = usuariosDAO.ObtenerUsuarioPorNombre(nombreUsuario);

            // Verifica si el usuario existe y si la clave coincide
            if (usuario != null && usuario.ClaveUsuario == claveUsuario)
            {
                // Aquí podrías hacer más lógica, como establecer la sesión de usuario
                return true; // Usuario autenticado correctamente
            }

            return false; // Fallo en la autenticación
        }

        // Otros métodos relacionados a la gestión de usuarios se pueden agregar aquí.
    }
}
