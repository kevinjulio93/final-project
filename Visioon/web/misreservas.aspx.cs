using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Visioon.negocio;

namespace Visioon.web
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        Reserva Mysreservas;
        long idestudiante;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {

                Response.Redirect("sesion.aspx");

            }
            else
            {

                nombreUsuario.Text = Session["usuario"].ToString();
                linkReservas.CssClass = "active";

            }

            Mysreservas = new Reserva();

            idestudiante = (long)Convert.ToInt32(Session["Id"].ToString());

            cargarMisReservas(idestudiante);
        }



        public void cargarMisReservas(long ID)
        {
            List<Reserva> listar = Mysreservas.SelecionarReserva("", ID);
            listaMisReservas.Value = Mysreservas.cargarMisReservas2(listar);
        }



        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("sesion.aspx");
        }

        protected void linkMisreservas_Click(object sender, EventArgs e)
        {
            linkMisreservas.CssClass = "active";
            linkReservas.CssClass = "";
            Response.Redirect("misreservas.aspx");
        }

        protected void linkReservas_Click(object sender, EventArgs e)
        {
            linkMisreservas.CssClass = "";
            linkReservas.CssClass = "active";
            Response.Redirect("inicio.aspx");

        }

        protected void linkInicio_Click(object sender, EventArgs e)
        {
            LinkInicio.CssClass = "";
            LinkInicio.CssClass = "active";
            Response.Redirect("principal.aspx");
        }
    }
}