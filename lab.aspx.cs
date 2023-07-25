using System;
using System.ComponentModel.Design;
using System.IO;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Windows.Forms;
using laboratorio3.ServiceReference1;
using System.Web;

namespace laboratorio3
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            añadirCiudades();

        }

        protected void añadirCiudades()
        {
            Service1Client client = new Service1Client();
            String[] ciudades = client.getCiudades();

            for (int i = 0; i < ciudades.Length; i++)
            {
                string s = ciudades[i];
                Ciudades.Items.Add(s);
            }
        }

        protected void Enviar_Boton(object sender, EventArgs e)
        {
            string nomSesion, apeSesion;
            string datos = "";
            string dato = nombre.Value;
            datos = "";
            datos += dato + "|";
            nomSesion = dato;

            dato = apellidos.Value;
            datos += dato + "|";
            apeSesion = dato;


            string sexoCookie = "";
            if (Male.Checked == true)
            {
                datos += "mas" + "|";
                sexoCookie = "Masculino";
            }
            else
            {
                datos += "fem" + "|";
                sexoCookie = "Femenino";
            }

            dato = eMail.Value;
            datos += dato + "|";

            dato = Direccion.Value;
            string dirCookie = "";
            if (dato == "")
            {
                datos += "-" + "|";
                dirCookie = "No especificó";
            }
            else
            {
                datos += dato + "|";
                dirCookie = dato;
            }

            dato = Ciudades.SelectedIndex.ToString();
            datos += dato + "|";
            string ciudadCookie = Ciudades.SelectedValue.ToString();

            dato = Requerimiento.Value;
            if (dato == "")
            {
                datos += "-" + "|";
            }
            else
            {
                datos += dato + "|";
            }

            Service1Client client = new Service1Client();
            client.EnviarService(datos);

            string hoz = "";
            nombre.Value = hoz;
            apellidos.Value = hoz;
            Male.Checked = false;
            Female.Checked = false;
            eMail.Value = hoz;
            Direccion.Value = hoz;
            Ciudades.SelectedIndex = 0;
            Requerimiento.Value = hoz;

            CrearSesion(nomSesion, apeSesion);
            CrearCookie(sexoCookie, ciudadCookie, dirCookie);

            Response.Redirect("Auxiliar");
        }

        private void CrearSesion(string nombre,string apellidos)
        {
            Session["Nombre"] = nombre;
            Session["Apellido"] = apellidos;
        }

        protected void CrearCookie(string sexo,string ciudad,string direccion)
        {
            Response.Cookies["usuario"]["sexo"] = sexo;
            Response.Cookies["usuario"]["ciudad"] = ciudad;
            Response.Cookies["usuario"]["direccion"] = direccion;
        }
    }
}