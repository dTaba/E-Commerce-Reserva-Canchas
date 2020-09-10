using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TutuCanchas.DAO
{
    public class BuscadorDAO
    {
        internal static string connectionString = @"Server=SQL5042.site4now.net;Database=DB_9CF8B6_Canchas;User Id=DB_9CF8B6_Canchas_admin;Password=huergo2019;";
        
        public DataTable actualizargrilla(string zonas, string tipodecancha, float preciomaximo, int horario)
        {
            try
            {   
                int horarionuevo = horario * 100;
                int horario2 = horarionuevo + 90;
                string SQL_DataGrilla = @"SELECT 
                                            Clubes.Nombre AS Club, 
	                                        Canchas.Nombre AS Cancha, 
	                                        CanchasHorarios.HoraDesde AS HoraDesde, 
	                                        CanchasHorarios.HoraHasta AS HoraHasta,
	                                        CanchasHorarios.Precio, 
	                                        Clubes.Direccion, 
	                                        CanchasTipos.Nombre AS Tipo, 
	                                        Clubes.Zona, 
	                                        CanchasHorarios.Id AS IdCanchaHorario, 
	                                        CanchasHorarios.IdCancha AS IdCancha
                                        FROM [dbo].[Canchas] 
                                        INNER JOIN [dbo].[CanchasHorarios] ON Canchas.Id = CanchasHorarios.IdCancha 
                                        INNER JOIN [dbo].[Clubes] ON Canchas.IdClub = Clubes.Id 
                                        INNER JOIN [dbo].[ClubesZonas] ClubZonas ON  ClubZonas.Id = Clubes.IdClubesZonas
                                        INNER JOIN [dbo].[CanchasTipos] ON Canchas.IdCanchasTipos = CanchasTipos.Id 
                                        LEFT JOIN  [dbo].[Reservas] R ON R.IdCancha =  Canchas.Id
                                        WHERE R.IdCancha IS NULL 
                                        AND CanchasTipos.Id = " + tipodecancha +
                                        "AND Clubes.IdClubesZonas = " + zonas +
                                        "AND CanchasHorarios.[HoraHasta] >= " + horarionuevo + " and CanchasHorarios.[HoraDesde] <= " + horario2 +
                                        "AND CanchasHorarios.Precio < " + preciomaximo +
                                        "ORDER BY CanchasHorarios.Precio";

            SqlConnection con = new SqlConnection(connectionString);
            con.ConnectionString =  connectionString;
            con.Open();

            SqlDataAdapter dataAdapt = new SqlDataAdapter(SQL_DataGrilla,con);
                
                DataTable dataTable = new DataTable();
                dataAdapt.Fill(dataTable);
                return dataTable;
                //con.Close();

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
    }
}
