using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Vision.negocio
{
    public class Conexion
    {
        private MySqlConnection conexion;
        private String msj;

        
        public Conexion()
        {
            try
            {
                this.conexion = new MySqlConnection();
                this.conexion.ConnectionString = ConfigurationManager.ConnectionStrings["MysqlConexion"].ConnectionString;
                this.conexion.Open();
                this.msj = "Exito en la conexion";
            }catch(Exception ex){
                Console.WriteLine(ex.Message.ToString());
                
            }

        }


        public Boolean agregar(String tabla,String columnas,String datos) {

            Boolean estado = false;

            try
            {
                String consulta = "INSERT INTO "+tabla+" ("+columnas+") VALUES ("+datos+");";

                MySqlCommand comand = new MySqlCommand(consulta, this.conexion);
                comand.ExecuteNonQuery();

                estado = true;

            }catch(Exception ex){

                estado = false;
                this.msj = ex.Message.ToString();

            }


            return estado;
        }

        
        public MySqlDataReader buscarUser(String tabla,String email,String contrasena){

            MySqlDataReader read = null;
            try
            {

                String consulta = "SELECT * FROM " + tabla + " WHERE usuario='" + email + "' and contrasena='" + contrasena + "';";

                MySqlCommand comand = new MySqlCommand(consulta, this.conexion);
                read = comand.ExecuteReader();

                read.Close();

            }
            catch (Exception ex) {
                read = null;
                this.msj = ex.Message.ToString();
            }
            return read;
        }

    }
}