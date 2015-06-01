using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Visioon.negocio;
using System.Windows.Forms;

namespace Visioon.web
{
    public partial class inicio : System.Web.UI.Page
    {

        private Reserva reserva;
        long idestudiante = 0;
       // String fechaSelecionada = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                reserva = new Reserva();
                msjOculto.Value = "";

                idestudiante = (long)Convert.ToInt32(Session["Id"].ToString());
                
                DReservas.Value=reserva.SelecionarReservaJson(idestudiante);
            }
            else
            {
                Response.Redirect("sesion.aspx");
            }
        }


        public void cargarDisponibilidad(String fecha, long idEstudiante)
        {
            List<Reserva> listar = reserva.SelecionarReserva(fecha, 0);
            listaDisponibilidad.Value = reserva.cargarTablaDisponibilidad(listar);
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {

            long idsala = 1;
            String fecha = txtFecha.Value;
            String horaentrada = txtHoraEntrada.Value;
            String horasalida = txtHoraSalida.Value;
            String descripcion = txtDesccripcion.Text;

            MessageBox.Show(""+fecha);

            reserva.Agregar(idsala, idestudiante, fecha, horaentrada, horasalida, descripcion);
            msjOculto.Value = reserva.Mensaje;
            //cargarDisponibilidad(fechaSelecionada, 0);
            DReservas.Value = reserva.SelecionarReservaJson(idestudiante);
        }

        



    }
}