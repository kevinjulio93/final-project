using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vision.negocio;
using MySql.Data.MySqlClient;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Visioon.negocio
{
    public class Reserva
    {
        private static String TABLA = "reserva";
        private String mensaje;
        private long idEstudiante;
        private long idReserva;


        private long idSala;
        private Conexion con;
        private String fecha;
        private String hora_inicio;
        private String hora_fin;
        private String descripcion;


        public Reserva()
        {
            this.con = new Conexion();
        }


        public long IdSala
        {
            get { return idSala; }
            set { idSala = value; }
        }

        public long IdEstudiante
        {
            get { return idEstudiante; }
            set { idEstudiante = value; }
        }

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }


        public String Hora_inicio
        {
            get { return hora_inicio; }
            set { hora_inicio = value; }
        }


        public String Hora_fin
        {
            get { return hora_fin; }
            set { hora_fin = value; }
        }

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public String Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }


        public long IdReserva
        {
            get { return idReserva; }
            set { idReserva = value; }
        }
        public List<Reserva> SelecionarReserva(String fecha, long idestudiante)
        {

            List<Reserva> lista = new List<Reserva>();
            String condicion = "";
            if (idestudiante != 0)
            {
                condicion = " estudiante='" + idestudiante + "' group by fecha";
            }
            else
            {
                condicion = "fecha='" + fecha + "'";

            }
            MySqlDataReader read = this.con.buscar(TABLA, condicion);
            this.mensaje = null;
            if (read.HasRows != false)
            {

                while (read.Read())
                {
                    Reserva reserva = new Reserva();
                    reserva.idReserva = (long)Convert.ToInt32(read["idreserva"].ToString());
                    reserva.idEstudiante = (long)Convert.ToInt32(read["estudiante"].ToString());
                    reserva.idSala = (long)Convert.ToInt32(read["sala"].ToString());

                    reserva.fecha = read["fecha"].ToString();
                    reserva.Hora_inicio = read["hora_inicio"].ToString();
                    reserva.Hora_fin = read["hora_fin"].ToString();
                    reserva.descripcion = read["descripcion"].ToString();

                    lista.Add(reserva);

                }

            }
            else
            {
                this.mensaje = "El usuario no existe";
            }
            read.Close();

            return lista;
        }

        public Boolean Agregar(long idSala, long idEstuante, String fecha, String hora_inicio, String hora_fin, String descripcion)
        {
            String columnas = "sala,estudiante, fecha, hora_inicio, hora_fin, descripcion";
            String datos = idSala + "," + idEstuante + ",'" + fecha + "','" + hora_inicio + "','" + hora_fin + "','" + descripcion + "'";

            if (this.con.agregar(TABLA, columnas, datos) == true)
            {
                this.mensaje = "1,Reserva exitosa";

                return true;

            }
            else
            {
                this.mensaje = "0,Error al crear reserva";

                return false;
            }


        }


        public Boolean AgregarSemanal(long idSala, long idEstuante, String fecha,String fechaFin, String hora_inicio, String hora_fin, String descripcion)
        {

            //"2015/05/10"

            DateTime fechaInicio = new DateTime(Convert.ToInt32(fecha.Split('/')[0]), Convert.ToInt32(fecha.Split('/')[1]), Convert.ToInt32(fecha.Split('/')[2]));

            DateTime fechaFinS = new DateTime(Convert.ToInt32(fechaFin.Split('/')[0]), Convert.ToInt32(fechaFin.Split('/')[1]), Convert.ToInt32(fechaFin.Split('/')[2]));



            String columnas = "sala,estudiante, fecha, hora_inicio, hora_fin, descripcion";
            String datos = idSala + "," + idEstuante + ",'" + fecha + "','" + hora_inicio + "','" + hora_fin + "','" + descripcion + "'";

            if (this.con.agregar(TABLA, columnas, datos) == true)
            {
                this.mensaje = "1,Reserva exitosa";

                return true;

            }
            else
            {
                this.mensaje = "0,Error al crear reserva";

                return false;
            }


        }


        public String cargarTablaDisponibilidad(List<Reserva> lista)
        {
            List<Disponibilidad> listadoA = new List<Disponibilidad>();


            for (int j = 0; j < 14; j++)
            {
                String hora = "";
                if (j < 3)
                {
                    hora = "0" + (7 + j) + ":00:00";
                }
                else
                {
                    hora = (7 + j) + ":00:00";
                }
                Disponibilidad d = new Disponibilidad(hora, "Disponible");
                listadoA.Add(d);
            }


            for (int i = 0; i < lista.Count; i++)
            {
                String horaInicio = lista.ElementAt(i).hora_inicio;
                String horaFin = lista.ElementAt(i).hora_fin;

                int intHoraInicio = Convert.ToInt32(horaInicio.Split(':').ElementAt(0).ToString());
                int intHoraFin = Convert.ToInt32(horaFin.Split(':').ElementAt(0).ToString());

                int horaDif = Math.Abs(intHoraInicio - intHoraFin) - 1;
                String horaDife = "";
                if (intHoraFin < 10)
                {
                    horaDife = "0" + (intHoraInicio + horaDif) + ":00:00";
                }
                else
                {
                    horaDife = (intHoraInicio + horaDif) + ":00:00";
                }



                for (int j = 0; j < listadoA.Count; j++)
                {

                    //MessageBox.Show("HORA DIF: " + horaDife);
                    if (listadoA.ElementAt(j).Hora.Equals(horaInicio) && listadoA.ElementAt(j).Estado.Equals("Disponible"))
                    {
                        listadoA.ElementAt(j).Estado = "No disponible";
                        //MessageBox.Show("Hora1: " + listadoA.ElementAt(j).Hora);
                    }

                    if (listadoA.ElementAt(j).Hora.Equals(horaDife) && listadoA.ElementAt(j).Estado.Equals("Disponible"))
                    {
                        listadoA.ElementAt(j).Estado = "No Disponible";
                        //MessageBox.Show("Hora2: " + listadoA.ElementAt(j).Hora);
                    }

                    //if (listadoA.ElementAt(j).Hora.Equals(horaFin) && listadoA.ElementAt(j).Estado.Equals("Disponible"))
                    //{
                    //    listadoA.ElementAt(j).Estado = "No Disponible";
                    //    //MessageBox.Show("Hora3: " + listadoA.ElementAt(j).Hora);
                    //}

                }


            }

            JavaScriptSerializer jss = new JavaScriptSerializer();


            return jss.Serialize(listadoA);
        }


        public String cargarMisReservas(List<Reserva> lista)
        {
            List<MisReservas> misReservas = new List<MisReservas>();
            List<object> itemListas = null;
            MisReservas misRe = null;
            JavaScriptSerializer jss = new JavaScriptSerializer();


            for (int i = 0; i < lista.Count; i++)
            {


                String Mes = lista.ElementAt(i).fecha.Split('/')[1].ToString();

                int IntMes = Convert.ToInt32(Mes);
                int bandera = 0;
                itemListas = new List<object>();


                int Mesnext = Convert.ToInt32(lista.ElementAt(i).fecha.Split('/')[1].ToString());


                String Horainicio = lista.ElementAt(i).hora_inicio;
                String Horafin = lista.ElementAt(i).hora_fin;
                String Dia = lista.ElementAt(i).fecha.Split('/')[0].ToString();
                Object objecReservas = null;

                objecReservas = new { Dia, Horainicio, Horafin };
                itemListas.Add(objecReservas);

                misRe = new MisReservas(Mes, itemListas);
                misReservas.Add(misRe);
                




            }

            

            return jss.Serialize(misReservas);

        }


        public String cargarMisReservas2(List<Reserva> lista)
        {
            List<MyReserva> misReservas = new List<MyReserva>();
            List<object> itemListas = null;
            MyReserva misRe = null;
            JavaScriptSerializer jss = new JavaScriptSerializer();


            for (int i = 0; i < lista.Count; i++)
            {


                int id = Convert.ToInt32(lista.ElementAt(i).IdReserva.ToString());
                String title = lista.ElementAt(i).Descripcion.ToString();
                String url = "#";
                String Class = "event-info";


                DateTime startfecha=new DateTime(2015,1,9,7,0,0);
                DateTime convStartFecha = startfecha.ToUniversalTime();
                

                DateTime dateValue = new DateTime(2015,1,9,7,0,0,0);
                //dateValue.ToString("fff");
                String start = dateValue.ToString("yyyMMddhhmmssfff");

                DateTime endfecha = new DateTime(2015, 1, 9, 9, 0, 0);
                DateTime convEndFecha = endfecha.ToUniversalTime();
                String end = convStartFecha.ToString() + "000";

               

                misRe = new MyReserva(id,title,url,Class,start,end);
                misReservas.Add(misRe);





            }



            return jss.Serialize(misReservas);

        }

        public String SelecionarReservaJson(long idestudiante)
        {

            List<DReservas> lista = new List<DReservas>();
            String sql = "CALL CARGAR_RESERVAS("+idestudiante+")";

            MySqlDataReader read = this.con.CallProcedure(sql);
            this.mensaje = null;
            if (read.HasRows != false)
            {

                while (read.Read())
                {
                    DReservas reserva = new DReservas();
                    reserva.id = (long)Convert.ToInt32(read["id"].ToString());
                    reserva.title = read["title"].ToString();
                    reserva.start = read["star"].ToString();
                    reserva.end = read["endf"].ToString();
                    reserva.color = read["color"].ToString();
                                   

                    lista.Add(reserva);

                }

            }
            else
            {
                this.mensaje = "No hay reservas";
            }
            read.Close();

            JavaScriptSerializer jss = new JavaScriptSerializer();


            return jss.Serialize(lista);
            
        }
    
    }

}






