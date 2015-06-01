using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visioon.negocio
{
    public class DReservas
    {

        public DReservas() { 
            
        }
        private long ids;

        public long id
        {
            get { return ids; }
            set { ids = value; }
        }
        private String titles;

        public String title
        {
            get { return titles; }
            set { titles = value; }
        }
        private String starts;

        public String start
        {
            get { return starts; }
            set { starts = value; }
        }
        private String ends;

        public String end
        {
            get { return ends; }
            set { ends = value; }
        }
        private String colors;

        public String color
        {
            get { return colors; }
            set { colors = value; }
        }



    }
}