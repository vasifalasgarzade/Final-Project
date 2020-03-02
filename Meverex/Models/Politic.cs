using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Meverex.Models
{
    public class Politic
    {
        public int Id { get; set; }
        [Required, MaxLength(200)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Required, MaxLength(200)]
        public string Tittle { get; set; }
        [Required, Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        [Required, MaxLength(200)]
        public string Icon { get; set; }
        [Required, MaxLength(200)]
        public string IconUrl { get; set; }
        public bool Status { get; set; }

    }
}