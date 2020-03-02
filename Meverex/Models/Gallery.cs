using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Meverex.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        [Required, MaxLength(250)]
        public string AuthorComment { get; set; }
        [Required, MaxLength(250)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
    }
}