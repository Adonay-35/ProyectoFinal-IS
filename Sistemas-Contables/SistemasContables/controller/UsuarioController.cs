using SistemasContables.DataBase;
using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasContables.controller
{
    public class UsuarioController
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
        public List<Usuario> getList()
        {
            return usuariosDAO.getList();
        }

        public bool insert(Usuario usuario)
        {
            return usuariosDAO.insert(usuario);  
        }

        public bool update(Usuario usuario)
        {
            return usuariosDAO.update(usuario);  
        }

        public void delete(int idUsuario)
        {
            usuariosDAO.delete(idUsuario);  // Elimina un usuario usando su id
        }

        public Usuario ObtenerUsuarioPorId(int idUsuario)
        {
            // Obtiene el usuario con el ID proporcionado y lo retorna
            return usuariosDAO.ObtenerUsuarioPorId(idUsuario);
        }


    }
}
