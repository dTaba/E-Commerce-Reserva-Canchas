using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TutuCanchas.DTO;
using System.Data.SqlClient;
using System.Data;

namespace TutuCanchas.DAO
{
    public class ReservasDAO
    {
        internal static string connectionString = @"Server=SQL5042.site4now.net;Database=DB_9CF8B6_Canchas;User Id=DB_9CF8B6_Canchas_admin;Password=huergo2019;";
        public void Create(ReservasDTO reservas)
        {
            //Genero el siguiente ID de reservas
            int id = DAOHelper.GetNextId("Reservas");
            //.ToString("yyyy-MM-dd HH:mm:ss")

            string SQL_Nuevareserva = "insert into Reservas values (" + id + ", " + reservas.IdCancha + ", '" + reservas.FechaHora + "' , " + reservas.IdUsuario + ", " + reservas.Precio + ", '" + reservas.Estado + "', " + reservas.IdCanchasHorario + ")";


            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = connectionString;
                con.Open();

                using (SqlCommand cmd = new SqlCommand(SQL_Nuevareserva, con))
                {
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = connectionString;
            //con.Open();
            //SqlCommand cmd = new SqlCommand(SQL_Nuevareserva, con);
            //cmd.ExecuteNonQuery();
            //con.Close();

        }

        public DataTable actualizargrilla()
        {
            try
            {

                string SQL_DataGrilla = "Select Id AS 'Identificador de Reserva', Precio, Estado from Reservas";

                SqlConnection con = new SqlConnection(connectionString);
                con.ConnectionString = connectionString;
                con.Open();
                SqlDataAdapter dataAdapt = new SqlDataAdapter(SQL_DataGrilla, con);

                DataTable dataTable = new DataTable();
                dataAdapt.Fill(dataTable);

                return dataTable;


            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public void borrarReservas(int id)
        {


        string SQL_DataGrilla2 = "Delete from Reservas where Id= '" + id + "'";

        SqlConnection con = new SqlConnection(connectionString);
        con.ConnectionString = connectionString;
        con.Open();
        SqlCommand command = new SqlCommand(SQL_DataGrilla2, con);
        
        command.ExecuteNonQuery();

        }
    }
}
