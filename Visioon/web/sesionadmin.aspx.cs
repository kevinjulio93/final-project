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
    public partial class sesionadmin : System.Web.UI.Page
    {
        private Admin administrador;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            administrador = new Admin();
        }

        protected void btnIniciarAdmin_Click(object sender, EventArgs e)
        {
            String email = txtUsuarioAdmin.Text;

            String contrasena = txtContrasenaAdmin.Text;

            List<Admin> listUsuarios = this.administrador.SelecionarUsuario(email, contrasena);

            if (listUsuarios.Count > 0)
            {
                long idUsuario = listUsuarios.ElementAt(0).Id;
                
                Session["admin"] = listUsuarios.ElementAt(0).Nombres;
                Session["Id"] = listUsuarios.ElementAt(0).Id;
                Response.Redirect("Administracion.aspx");

            }
            else
            {


                msjOcultoAdmin.Value = administrador.Mensaje;


            }
        }

        

        
    }
}