using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace laboratorio3
{
    public partial class Auxiliar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargarSesion();
            cookiesData.TextMode = TextBoxMode.MultiLine;
            cookiesData.ReadOnly = true;
        }

        protected void CargarSesion()
        {
            string info="";
            String nomSesion = (String)(Session["Nombre"]);
            String apeSesion = (String)(Session["Apellido"]);

            info += "Información de la sesión:";
            info += "<br/>" + "Nombres: " + nomSesion;
            info += "<br/>" + "Apellidos: " + apeSesion;

            contenidoSesion.InnerHtml = info;
        }

        protected void CerrarSesion(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("lab");
        }

        protected void CargarCookie(object sender, EventArgs e)
        {
            string infoCookies = "";
            infoCookies += Request.Cookies["usuario"]["sexo"].ToString()+"\r\n";
            infoCookies += Request.Cookies["usuario"]["ciudad"].ToString() + "\r\n";
            infoCookies += Request.Cookies["usuario"]["direccion"].ToString() + "\r\n";

            cookiesData.Text = infoCookies;
        }
    }
}