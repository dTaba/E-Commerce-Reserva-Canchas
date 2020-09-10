using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using TutuCanchas.Business;
using TutuCanchas.DTO;

namespace TutuCanchas_GP1
{
    public partial class Buscador : System.Web.UI.Page
    {
        public int idzona;
        public int idtipo;
        public string horarioconformato;
        public int horarioelegido;
        public string diaelegido;
        public string horarioelegido2;
        protected void Page_Init(object sender, EventArgs e)
        {
            CanchasTipos canchastipos = new CanchasTipos();
            List<CanchasTiposDTO> tipos = canchastipos.llenarddltipos();
            foreach (CanchasTiposDTO tipo in tipos)
            {
                ddTipoCancha.Items.Add(new ListItem(tipo.Nombre, tipo.Id.ToString()));
            }

            ClubesZonas clubezonas = new ClubesZonas();
            List<ClubesZonasDTO> zonas = clubezonas.llenarddlzonas();
            foreach (ClubesZonasDTO zona in zonas)
            {
                ddZonas.Items.Add(new ListItem(zona.Nombre,zona.Id.ToString()));

            }
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
                Response.Redirect("Login.aspx");

            if (!Page.IsPostBack)
            {
                ddHorario.Items.Clear();
                for (int i = 1; i < 25; i++)
                {
                    ddHorario.Items.Add(i.ToString());
                }
            }
            txFecha.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {

            string valorddhorario = ddHorario.SelectedValue;
            int valorddhorarioconvertido = Convert.ToInt32(valorddhorario);
            float precioconvertido = float.Parse(txPrecio.Text);

            BuscadorBusiness buscadorbusiness = new BuscadorBusiness();
            DataTable dt = new DataTable();
            dt = buscadorbusiness.RellenarGrilla(ddZonas.SelectedValue, ddTipoCancha.SelectedValue, precioconvertido, valorddhorarioconvertido);

            gvCanchas.AutoGenerateColumns = true;
            gvCanchas.DataSource = dt;
            gvCanchas.DataBind();


            horarioelegido = Convert.ToInt32(ddHorario.SelectedValue);
            diaelegido = txFecha.Text;

            //Paso datos del para la fecha de la reserva
            Session.Add("DiaElegido", diaelegido);
            Session.Add("HorarioElegido2", horarioelegido);

        }

        protected void btConfirmar_Click(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
                Response.Redirect("Login.aspx");
            else
                Response.Redirect("");
                    
        }

        protected void gvCanchas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //Selecciono los datos dependiendo la columna del grid
            string nombre = gvCanchas.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text;
            string horario = gvCanchas.Rows[Convert.ToInt32(e.CommandArgument)].Cells[3].Text;
            string precio = gvCanchas.Rows[Convert.ToInt32(e.CommandArgument)].Cells[5].Text;
            string direccion = gvCanchas.Rows[Convert.ToInt32(e.CommandArgument)].Cells[6].Text;
            string tipo = gvCanchas.Rows[Convert.ToInt32(e.CommandArgument)].Cells[7].Text;
            string zona = gvCanchas.Rows[Convert.ToInt32(e.CommandArgument)].Cells[8].Text;
            string idcanchahorario = gvCanchas.Rows[Convert.ToInt32(e.CommandArgument)].Cells[9].Text;
            string idcancha = gvCanchas.Rows[Convert.ToInt32(e.CommandArgument)].Cells[10].Text;

            idzona = Convert.ToInt32(ddZonas.SelectedValue);
            


            //Paso datos de la cancha para detalles reserva
            Session.Add("Nombre", nombre);
            Session.Add("Direccion", direccion);
            Session.Add("Zona", zona);
            Session.Add("Horario", Convert.ToInt32(horario));
            Session.Add("Precio", precio);
            Session.Add("Tipo", tipo);
            Session.Add("IdCanchaHorario",idcanchahorario);
            Session.Add("IdCancha",idcancha);

            Response.Redirect("DetallesReserva.aspx");
        }

        protected void gvCanchas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void btBuscar_Init(object sender, EventArgs e)
        {

        } 
    }
}
    