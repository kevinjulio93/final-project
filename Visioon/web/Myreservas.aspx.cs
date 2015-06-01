using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Visioon.negocio;

namespace Visioon.web
{
    public partial class misreservas : System.Web.UI.Page
    {
        Reserva Mysreservas;
        private long idestudiante;
        protected void Page_Load(object sender, EventArgs e)
        {
             if (Session["usuario"] != null)
            {
                Mysreservas = new Reserva();
                msjOculto.Value = "";
                msjOculto.Value = Mysreservas.Mensaje;

                idestudiante = (long)Convert.ToInt32(Session["Id"].ToString());

                cargarMisReservas(idestudiante);
                
            }
            else
            {
                Response.Redirect("sesion.aspx");
            }
            
        }


        public void cargarMisReservas(long ID) {
            List<Reserva> listar = Mysreservas.SelecionarReserva("", ID);
            listaMisReservas.Value = Mysreservas.cargarMisReservas(listar);
        }

       
    }
}