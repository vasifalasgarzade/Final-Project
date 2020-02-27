using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meverex.Models
{
    public class AboutUs
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Tittle { get; set; }

        public string Body { get; set; }
        public bool  Status { get; set; }

    }
}