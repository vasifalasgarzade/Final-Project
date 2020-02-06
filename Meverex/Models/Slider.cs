using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meverex.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string Tittle { get; set; }
        public DateTime Date { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public string Icon { get; set; }
        public string IconUrl { get; set; }
        public bool Status { get; set; }
    }
}