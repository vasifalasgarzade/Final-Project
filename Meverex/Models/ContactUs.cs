using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meverex.Models
{
    public class ContactUs
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Photo { get; set; }
        public string Desc { get; set; }
        public string Number { get; set; }
        public string Location { get; set; }
    }
}