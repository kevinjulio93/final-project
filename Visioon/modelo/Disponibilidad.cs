using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visioon.negocio
{
    public class Disponibilidad
    {
        private String hora;


        private String estado;

        

        public Disponibilidad(String hora,String estado) {
            this.hora = hora;
            this.estado = estado;
        }



        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public String Hora
        {
            get { return hora; }
            set { hora = value; }
        }
    }
}