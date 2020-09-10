using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;
using TutuCanchas.DAO;

namespace TutuCanchas.Business
{
    public class CanchasTipos
    {
        
        public List<CanchasTiposDTO> llenarddltipos()
        { 
            CanchasTiposDAO dao = new CanchasTiposDAO();

            List<CanchasTiposDTO> lista = dao.ReadAll();

            return lista;
        }
    }
}
