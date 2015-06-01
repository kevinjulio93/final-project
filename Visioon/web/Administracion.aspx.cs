using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Visioon.negocio;

namespace Visioon.web
{
    public partial class Administracion1 : System.Web.UI.Page
    {
        private Reserva reserva;
        long idestudiante = 0;
        String fechaSelecionada = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                reserva = new Reserva();
                msjOculto.Value = "";

                idestudiante = (long)Convert.ToInt32(Session["Id"].ToString());

                DateTime hoy = DateTime.Today;

                String dia = hoy.Day.ToString();
                String mes = hoy.Month.ToString();
                String anio = hoy.Year.ToString();
                fechaSelecionada = anio + "/" + mes + "/" + dia;

                //MessageBox.Show("Fecha: " + fechaSelecionada);

                cargarDisponibilidad(fechaSelecionada, 0);
            }
            else
            {
                Response.Redirect("sesionadmin.aspx");
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
            String fecha = txtFecha.Text.Split('/')[2] + "/" + txtFecha.Text.Split('/')[0] + "/" + txtFecha.Text.Split('/')[1];
            String horaentrada = txtHoraEntrada.Text;
            String horasalida = txtHoraSalida.Text;
            String descripcion = "Esto es una Descripcion";
            reserva.Agregar(idsala, idestudiante, fecha, horaentrada, horasalida, descripcion);
            msjOculto.Value = reserva.Mensaje;
            cargarDisponibilidad(fechaSelecionada, 0);

            txtHoraEntrada.Text = "";
            txtHoraSalida.Text = "";
        }

        protected void txtFecha_TextChanged(object sender, EventArgs e)
        {
            String fecha = txtFecha.Text.Split('/')[2] + "/" + txtFecha.Text.Split('/')[0] + "/" + txtFecha.Text.Split('/')[1];
            cargarDisponibilidad(fecha, 0);
        }



    }
}