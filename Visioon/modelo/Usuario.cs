using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Vision.negocio
{
    public class Usuario
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
        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        private String contrasena;

        public String Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
        private String programa;


        public String Programa
        {
            get { return programa; }
            set { programa = value; }
        }
        private DateTime fecha_nacimiento;


        public DateTime Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }
        private String foto;

        public String Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        private static String TABLA = "estudiante";

        private String mensaje;

        public String Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        private Conexion con;

        public Usuario()
        {
            this.con = new Conexion();

        }


        public Boolean Agregar(String identificacion, String nombres, String apellidos, String email, String constrasena, String programa, String fecha_nacimiento, String foto)
        {

            String columnas = " identificacion, nombres, apellidos, usuario, contrasena, programa, fecha_nacimiento, foto";
            String datos = "'" + identificacion + "','" + nombres + "','" + apellidos + "','" + email + "','" + contrasena + "','" + programa + "','" + fecha_nacimiento + "','" + foto + "'";

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

        public List<Usuario> SelecionarUsuario(String email, String contrasena)
        {

            List<Usuario> lista = new List<Usuario>();

            MySqlDataReader read = this.con.buscarUser(TABLA, email, contrasena);

            this.mensaje = null;
            if (read.HasRows != false)
            {

                while (read.Read())
                {
                    Usuario u = new Usuario();
                    u.Id = (long)Convert.ToInt32(read["idestudiante"].ToString());
                    u.nombres = read["nombres"].ToString();
                    u.apellidos = read["apellidos"].ToString();
                    u.email = read["usuario"].ToString();
                    u.contrasena = read["contrasena"].ToString();
                    u.fecha_nacimiento = Convert.ToDateTime(read["fecha_nacimiento"].ToString());
                    u.foto = read["foto"].ToString();
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