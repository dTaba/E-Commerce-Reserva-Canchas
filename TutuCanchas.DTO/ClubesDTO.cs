using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutuCanchas.DTO
{
    public class ClubesDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Zona { get; set; }
        public int IdClubesZona { get; set; }
        public int IdDueño { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }

    }
}
