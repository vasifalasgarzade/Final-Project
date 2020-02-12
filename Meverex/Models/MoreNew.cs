using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meverex.Models
{
    public class MoreNew
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
       
        public string Photo { get; set; }
        public string Tittle { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}