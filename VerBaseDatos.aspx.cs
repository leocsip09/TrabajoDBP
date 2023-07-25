using proyecto_ti.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto_ti
{
    public partial class VerBaseDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            verObjetos();
            infoObjetos();
        }

        protected void verObjetos()
        {
            Service1Client cliente = new Service1Client();
            String[] objetos = cliente.getObjetosBD();

            if (Implementos.Items.Count != objetos.Length)
            {
                for (int i = 0; i < objetos.Length; i++)
                {
                    string o = objetos[i];
                    Implementos.Items.Add(o);
                }
            }
        }

        protected void infoObjetos()
        {
            Service1Client client = new Service1Client();

            String[] deportes = client.getDeporteBD();
            int[] cantidades = client.getCantidadBD();
            String[] observaciones = client.getDetallesBD();
            Boolean[] estados = client.getEstadoBD();

            Deporte.Text = deportes[Implementos.SelectedIndex];
            Cantidad.Text = cantidades[Implementos.SelectedIndex].ToString();
            Observaciones.Text = observaciones[Implementos.SelectedIndex];
            Disponible.Text = BoolToString(estados[Implementos.SelectedIndex]);
        }

        protected String BoolToString(Boolean val)
        {
            if (val)
            {
                return "Si";
            }
            return "No";
        }
    }
}