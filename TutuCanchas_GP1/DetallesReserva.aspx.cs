using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutuCanchas.Business;

namespace TutuCanchas_GP1
{
    public partial class DetallesReserva : System.Web.UI.Page
    {
        public string horarioconformato;
        public string minutos2;
        protected void Page_Load(object sender, EventArgs e)
        {
            int hr = (int)Session["HorarioElegido2"];
            int hr2 = hr * 100;
            int minutos = (int)Session["Horario"] - hr2; //Estos van a ser los minutos, basicamente estoy acomodando el formato
            string hora = hr.ToString();
            if (minutos < 10)
            {
                minutos2 = "0" + minutos.ToString();
                horarioconformato = hora + ":" + minutos2 + ":00";
            }
            else
            {
                horarioconformato = hora + ":" + minutos.ToString() + ":00";
            }
            

            //Paso los datos de la reserva a traves de el uso de Session
            lblFechaa.Text = (string)Session["Fecha"];
            lblHorarioo.Text = horarioconformato;
            lblDireccionn.Text = (string)Session["Direccion"] + " Barrio: " + (string)Session["Zona"];
            lblTipoo.Text = (string)Session["Tipo"];
            lblPrecioo.Text = (string)Session["Precio"]+ " $";
            lblFechaa.Text = (string)Session["DiaElegido"];
        }

        protected void btConfirmar_Click(object sender, EventArgs e)
        {   
            //Instancio reservas para invocacar su metodo
            Reservas reservas = new Reservas();

            //Acomodo ciertos datos para luego pasarlos por parametro a lo que teminara siendo el query
            int idcanchas = Convert.ToInt32((string)Session["IdCancha"]);
            int idcanchashorarios = Convert.ToInt32((string)Session["IdCanchaHorario"]);
            string fechayhorasql = (string)Session["DiaElegido"] + " " + horarioconformato;
            
            //(string)Session["HorarioElegido"]

            //Llamo al business de agregar reservas y voy pasando parametros
            //Paso dos unos Hardcodeados como parametro, uno porque solo es posible el ingreso de un usuario cuyo id es 1 y el otro debido a que mas tarde generare el id a traves del dao helper
            reservas.AgregarReservas(fechayhorasql, (string)Session["Precio"],"Reservado",1, idcanchas,1, idcanchashorarios);
            Response.Redirect("Reserva2.aspx");

        }
    }                   
}