using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Visioon.negocio;

namespace Visioon.web
{
    public partial class historial : System.Web.UI.Page
    {

        Reserva Mysreservas;
        long idestudiante;
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
            Session["admin"] = null;
            Response.Redirect("sesionadmin.aspx");
        }

        protected void linkMisreservas_Click(object sender, EventArgs e)
        {
            linkMisreservas.CssClass = "active";
            linkReservas.CssClass = "";
            Response.Redirect("historial.aspx");
        }

        protected void linkReservas_Click(object sender, EventArgs e)
        {
            linkMisreservas.CssClass = "";
            linkReservas.CssClass = "active";
            Response.Redirect("Administracion.aspx");

        }
    }
}