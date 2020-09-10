using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TutuCanchas.Business;
using TutuCanchas.DTO;

namespace TutuCanchas_GP1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //"Data Source=SQL5042.site4now.net;Initial Catalog=DB_9CF8B6_Canchas;User Id=DB_9CF8B6_Canchas_admin;Password=YOUR_DB_PASSWORD;"


        }

        protected void btIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                UsuariosDTO usuario = Usuarios.IniciarSesion(txUsuario.Text, txContraseña.Text);
                if (usuario != null)
                {
                    Session.Add("usuario", txUsuario.Text);
                    Response.Redirect("Buscador.aspx");
                }
                else
                {
                    lbMsg.Text = "Usuario o Contraseña Incorrecto <br/> (Pruebe user1 y 1234)";
                }

            
            }
            catch (Exception ex)
            {
                lbMsg.Text = ex.Message;
            }
        }
    }
}