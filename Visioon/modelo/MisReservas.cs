using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visioon.negocio
{
    public class MisReservas
    {
        private String mes;
        private List<object> listaitem = new List<object>();

        public MisReservas(String mes, List<object> listaitem)
        {
            this.mes = mes;
            this.listaitem = listaitem;
        }

        public String Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public List<object> Listaitem
        {
            get { return listaitem; }
            set { listaitem = value; }
        }
    }
}