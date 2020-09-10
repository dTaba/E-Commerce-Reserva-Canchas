using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TutuCanchas.DTO
{
    public class CanchasHorariosDTO
    {
        public int Id { get; set; }
        public int IdCancha { get; set; }
        public int HoraDesde { get; set; }
        public int HoraHasta { get; set; }
        public string Dia { get; set; }
        public double Precio { get; set; }
    }
}
