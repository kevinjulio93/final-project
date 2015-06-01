using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Vision.negocio;
using System.Web.Util;
using System.Windows.Forms; 
using System.Web.Script.Serialization;
using System.IO;
using System.Web.UI.HtmlControls;


namespace Vision.web
{
	public partial class login : System.Web.UI.Page
	{

        private Usuario estudiante;
        private Usuario estudiante2;

         
		protected void Page_Load(object sender, EventArgs e)
		{
            this.estudiante = new Usuario();

            estudiante = new Usuario();

            estudiante.Nombres = "Nombre1";
            estudiante.Apellidos = "Apellido1";
            estudiante.Email = "Email1";

            estudiante2 = new Usuario();

            estudiante.Nombres = "Nombre1";
            estudiante.Apellidos = "Apellido1";
            estudiante.Email = "Email1";


            List<Usuario> lista = new List<Usuario>();
            lista.Add(estudiante);
            lista.Add(estudiante2);

            JavaScriptSerializer jss = new JavaScriptSerializer();

             


            
            loco.Value = jss.Serialize(lista);

            



		}

        protected void btnLogin_Click(object sender, EventArgs e)
        {



            MessageBox.Show(sender.ToString());

           // Response.Redirect("index.aspx");

            //MessageBox.Show("" + Session["usuario"].ToString());

            //String email = txtusuario.Text;
            //String contrasena = txtcontrasena.Text;
            //List<Usuario> estu = this.estudiante.SelecionarUsuario(email, contrasena);

            //if (this.estudiante.SelecionarUsuario(email, contrasena) != null)
            //{
            //    for (int i = 0; i < estu.Count; i++) {
            //        Session["usuario"] = estu.ElementAt(i).Nombres + " " + estu.ElementAt(i).Apellidos;
                    
            //    }
                   
            //        Response.Redirect("index.aspx");
            //}
            //else { 
                
                
            
            //}

            
        }
	}
}