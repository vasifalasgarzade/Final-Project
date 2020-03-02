using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meverex.Models
{
    public class AboutUs
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Required,MaxLength(200)]
        public string Tittle { get; set; }

        [Required, Column(TypeName = "ntext"), AllowHtml]
        public string Body { get; set; }
        public bool  Status { get; set; }

    }
}