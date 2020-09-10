using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;
using TutuCanchas.DAO;

namespace TutuCanchas.Business
{
    public class ClubesZonas
    {
       public List<ClubesZonasDTO> llenarddlzonas()
            {
                ClubesZonasDAO dao = new ClubesZonasDAO();

                List<ClubesZonasDTO> lista = dao.ReadAll();

                return lista;
            }
        }
    }

