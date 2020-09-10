using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutuCanchas.DTO
{
    [Serializable]
    public class UsuariosDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string Perfil { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
