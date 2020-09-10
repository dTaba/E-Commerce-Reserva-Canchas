using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;
using TutuCanchas.DAO;
using System.Data;

namespace TutuCanchas.Business
{
    public class Reservas
    {
        public  void AgregarReservas(string fecha, string precio, string estado, int id, int idcanchas, int idusuario , int idcanchashorarios)
        {
           ReservasDTO agregarReservaDTO = new ReservasDTO();



           agregarReservaDTO.FechaHora = fecha;
           agregarReservaDTO.Precio = float.Parse(precio);
           agregarReservaDTO.Estado = estado;
           agregarReservaDTO.Id = id;
           agregarReservaDTO.IdCancha = idcanchas;
           agregarReservaDTO.IdUsuario = idusuario;
           agregarReservaDTO.IdCanchasHorario = idcanchashorarios;

           try
           {
               ReservasDAO reservasdao = new ReservasDAO();
               reservasdao.Create(agregarReservaDTO);
           }
           catch (Exception ex)
           {
            
           }
        }
        public DataTable RellenarGrilla()
        {
            ReservasDAO asignarcampos = new ReservasDAO();

            return asignarcampos.actualizargrilla();
        }
        public void borrarReservas(int id)
        {
            ReservasDAO dao = new ReservasDAO();

            dao.borrarReservas(id);
        }

    }

}
