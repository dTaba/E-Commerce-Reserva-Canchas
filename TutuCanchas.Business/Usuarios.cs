using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;

namespace TutuCanchas.Business
{
    public static class Usuarios
    {
        public static UsuariosDTO IniciarSesion(string usuario, string contraseña)
        {
            var usuarios = DAO.UsuariosDAO.ReadAll(
                "WHERE Nombre='[usuario]' AND Contraseña='[contraseña]'"
                .Replace("[usuario]", usuario)
                .Replace("[contraseña]", contraseña));

            if (usuarios.Count > 0)
                return usuarios[0];

            return null;
        }
    }
}
