using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using TutuCanchas.Business;


namespace TutuCanchas_GP1
{
    public partial class Reserva2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)     //Si la sesion no esta iniciada, volvemos al Login.
                Response.Redirect("Login.aspx");

            Reservas reservasbusiness = new Reservas();
            DataTable dt = new DataTable();
            dt = reservasbusiness.RellenarGrilla();

            gvReservas.AutoGenerateColumns = true;
            gvReservas.DataSource = dt;
            gvReservas.DataBind();
            
        }

        protected void gvReservas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string idreserva = gvReservas.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text;
            Session.Add("IdReserva", idreserva);

            Reservas reserva = new Reservas();
            int idreservaa = Convert.ToInt32(idreserva);
            reserva.borrarReservas(idreservaa);
        }

        protected void gvReservas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}