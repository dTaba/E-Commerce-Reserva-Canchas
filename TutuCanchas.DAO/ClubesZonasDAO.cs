using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;
using System.Data;
using System.Data.SqlClient;

namespace TutuCanchas.DAO
{
    public class ClubesZonasDAO
    {
        public List<ClubesZonasDTO> ReadAll()
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM ClubesZonas ", DAOHelper.connectionString))
            {
                da.Fill(dt);
            }

            ClubesZonasDTO dto2;
            List<ClubesZonasDTO> lista = new List<ClubesZonasDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                dto2 = new ClubesZonasDTO();

                if (!dr.IsNull("Id")) dto2.Id = (int)dr["Id"];
                if (!dr.IsNull("Nombre")) dto2.Nombre = (string)dr["Nombre"];
                if (!dr.IsNull("Descripcion")) dto2.Direccion = (string)dr["Descripcion"];
                lista.Add(dto2);
            }

            return lista;
        }
    }
}
