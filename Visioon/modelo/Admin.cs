using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Vision.negocio
{
    public class Admin
    {

        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private String identificacion;

        public String Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        private String nombres;

        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private String apellidos;

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private String usuario;

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private String contrasena;

        public String Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }


        private static String TABLA = "administrador";

        private String mensaje;

        public String Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        private Conexion con;

        public Admin()
        {
            this.con = new Conexion();

        }


        public Boolean Agregar(String identificacion, String nombres, String apellidos, String email, String contrasena)
        {

            String columnas = " identificacion, nombres, apellidos, usuario, contrasena";
            String datos = "'" + identificacion + "','" + nombres + "','" + apellidos + "','" + email + "','" + contrasena + "'";

            if (this.con.agregar(TABLA, columnas, datos))
            {
                this.mensaje = "1,Registro exitoso";
                return true;
            }
            this.mensaje = "0,Error en el registro";
            return false;

        }

        public Boolean Eliminar()
        {
            return true;
        }

        public List<Admin> SelecionarUsuario(String email, String contrasena)
        {

            List<Admin> lista = new List<Admin>();

            MySqlDataReader read = this.con.buscarUser(TABLA, email, contrasena);

            this.mensaje = null;
            if (read.HasRows != false)
            {

                while (read.Read())
                {
                    Admin u = new Admin();
                    u.Id = (long)Convert.ToInt32(read["idadministrador"].ToString());
                    u.nombres = read["nombres"].ToString();
                    u.apellidos = read["apellidos"].ToString();
                    u.usuario = read["usuario"].ToString();
                    u.contrasena = read["contrasena"].ToString();

                    lista.Add(u);

                }

            }
            else
            {
                this.mensaje = "0,El usuario no existe";

            }
            read.Close();

            return lista;
        }


    }
}