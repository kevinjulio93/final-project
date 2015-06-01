using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace Vision.negocio
{
    public class Administrador
    {
        private String identificacion;
        private String nombres;
        private String apellidos;
        private String email;
        private String contrasena;
        

        private Conexion con;
        public Administrador() 
        {
            con = new Conexion();
            
        }


        public Boolean Agregar(String identificacion,String nombres,String apellidos, String email,String constrasena) {

            return true;
        }

        public Boolean Eliminar(long id)
        {

            return true;
        }

        public List<Administrador> Selecionar(long id)
        {
            return null;
        }


        
    }
}