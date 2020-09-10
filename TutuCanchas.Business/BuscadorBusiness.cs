using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutuCanchas.DAO;
using TutuCanchas.DTO;
using System.Data.SqlClient;
using System.Data;

namespace TutuCanchas.Business
{
    public class BuscadorBusiness
    {
        
        public DataTable RellenarGrilla(string zonas, string tiposdecancha, float prexiomaximo, int horario)
        {
            BuscadorDAO asignarcampos = new BuscadorDAO();

            return asignarcampos.actualizargrilla(zonas, tiposdecancha, prexiomaximo, horario);
        }
    }
}
