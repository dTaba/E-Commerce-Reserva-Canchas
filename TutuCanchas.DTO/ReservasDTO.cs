using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutuCanchas.DTO
{
    public class ReservasDTO
    {
        public int Id { get; set; }
        public int IdCancha { get; set; }
        public string FechaHora { get; set; }
        public int IdUsuario { get; set; }
        public float Precio { get; set; }
        public string Estado { get; set; }
        public int IdCanchasHorario { get; set; }
    }
}
