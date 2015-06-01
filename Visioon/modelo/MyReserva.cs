using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Visioon.negocio
{
    public class MyReserva
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        private String url;

        public String Url
        {
            get { return url; }
            set { url = value; }
        }
        private String Class;

        public String Class1
        {
            get { return Class; }
            set { Class = value; }
        }
        private String star;

        public String Star
        {
            get { return star; }
            set { star = value; }
        }
        private String end;

        public String End
        {
            get { return end; }
            set { end = value; }
        }

        public MyReserva(int id,String title,String url,String Class,String star,String end) {

            this.id = id;
            this.title = title;
            this.url = url;
            this.Class = Class;
            this.star = star;
            this.end = end;
        }


        
    }
}