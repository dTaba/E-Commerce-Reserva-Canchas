using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;
using System.Data;
using System.Data.SqlClient;
using TutuCanchas.DAO;

namespace TutuCanchas.DAO
{   //CRUD
    public class CanchasTiposDAO
    {
        protected SqlConnection Conexion = new SqlConnection("Server=SQL5042.site4now.net;Database=DB_9CF8B6_Canchas;User Id=DB_9CF8B6_Canchas_admin;Password=huergo2019;");
        SqlCommand Comando = new SqlCommand();

        internal static string connectionString = @"Server=SQL5042.site4now.net;Database=DB_9CF8B6_Canchas;User Id=DB_9CF8B6_Canchas_admin;Password=huergo2019;";
        
        
        
        public void Create(CanchasTiposDTO canchastipo)
        {
            string SQL_NuevoTipo = "insert into CanchasTipos values (" + canchastipo.Nombre + ")";

            SqlConnection con = new SqlConnection();
            con.ConnectionString =  connectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand(SQL_NuevoTipo, con);
            cmd.ExecuteNonQuery();
            con.Close();

            }



        public List<CanchasTiposDTO> ReadAll()
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM CanchasTipos " , DAOHelper.connectionString))
            {
                da.Fill(dt);
            }

            CanchasTiposDTO dto;
            List<CanchasTiposDTO> lista = new List<CanchasTiposDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                dto = new CanchasTiposDTO();

                if (!dr.IsNull("Id")) dto.Id = (int)dr["Id"];
                if (!dr.IsNull("Nombre")) dto.Nombre = (string)dr["Nombre"];
                lista.Add(dto);
            }

            return lista;
        }
    }
}
