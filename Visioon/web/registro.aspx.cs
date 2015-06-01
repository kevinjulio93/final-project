using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vision.negocio;

namespace Vision.web
{
    public partial class registro : System.Web.UI.Page
    {

        private Usuario us;
        protected void Page_Load(object sender, EventArgs e)
        {
            us = new Usuario();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            String identificacion = txtidentificacion.Text;
            String nombres = txtnombres.Text;
            String apellidos = txtapellidos.Text;
            String correo = txtcorreo.Text;
            String contrasena = txtcontrasena.Text;
            String programa = txtprograma.Text;
            String fecha_nacimiento = txtfecha_nacimiento.Text;

            if (us.Agregar(identificacion, nombres, apellidos, correo, contrasena, programa, fecha_nacimiento, "foto"))
            {
                msjOculto.Value = us.Mensaje;
            }

            
        }
    }
}