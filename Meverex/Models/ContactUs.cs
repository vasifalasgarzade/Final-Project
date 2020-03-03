using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meverex.Models
{
    public class ContactUs
    {
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Tittle { get; set; }

        [MaxLength(200)]
        public string Photo { get; set; }

        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }

        [Required, Column(TypeName ="ntext") ]
        public string Desc { get; set; }
        [Required, MaxLength(200)]
        public string Number { get; set; }
        [Required, MaxLength(200)]
        public string Location { get; set; }
        public int OrderBy { get; set; }
    }
}