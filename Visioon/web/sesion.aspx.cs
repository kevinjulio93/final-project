using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Vision.negocio;

namespace Visioon.web
{
    public partial class sesion : System.Web.UI.Page
    {
        private Usuario docente;
        protected void Page_Load(object sender, EventArgs e)
        {
            docente = new Usuario();
        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            String email = txtUsuario.Text;

            String contrasena = txtContrasena.Text;

            List<Usuario> docen = this.docente.SelecionarUsuario(email, contrasena);

            if (docen.Count > 0)
            {

                Session["usuario"] = docen.ElementAt(0).Nombres;
                Session["Id"] = docen.ElementAt(0).Id;
                Response.Redirect("inicio.aspx");

            }
            else
            {


                msjOculto.Value = docente.Mensaje;


            }
        }
    }
}