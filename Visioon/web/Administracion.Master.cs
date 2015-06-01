using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Visioon.web
{
    public partial class Administracion : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] == null)
            {

                Response.Redirect("sesionadmin.aspx");

            }
            else
            {

                nombreUsuario.Text = Session["admin"].ToString();
                linkReservas.CssClass = "active";

            }
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Response.Redirect("sesionadmin.aspx");
        }

        
        
            

        protected void linkReservas_Click(object sender, EventArgs e)
        {
            linkMisreservas.CssClass = "";
            linkReservas.CssClass = "active";
            Response.Redirect("Administracion.aspx");

        }

        protected void linkHistorial_Click(object sender, EventArgs e)
        {
            linkMisreservas.CssClass = "active";
            linkReservas.CssClass = "";
            Response.Redirect("historial.aspx");
        }
    }
}