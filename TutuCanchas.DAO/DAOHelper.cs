using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TutuCanchas.DAO
{
    public static class DAOHelper
    {
        internal static string connectionString = @"Server=SQL5042.site4now.net;Database=DB_9CF8B6_Canchas;User Id=DB_9CF8B6_Canchas_admin;Password=huergo2019;";

        //Get next id genérico.
        internal static int GetNextId(string tableName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = @"SELECT IsNull(MAX(Id),0) FROM " + tableName;

                    int ultimoId = (int)cmd.ExecuteScalar();

                    return ultimoId + 1;
                }
            }
        }
    }
}
