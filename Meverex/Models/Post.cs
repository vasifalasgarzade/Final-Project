using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Meverex.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required, MaxLength(300)]
        public string Title { get; set; }
        [Required, MaxLength(500)]
        public string Description { get; set; }
        [ MaxLength(300)]
        public string Photo { get; set; }

        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Required, MaxLength(200)]
        public string AuthorComment { get; set; }
        [Required, Column(TypeName = "ntext"), AllowHtml]
        public string Text { get; set; }
        [Required, MaxLength(200)]
        public string Commnet { get; set; }
        public bool Status { get; set; }


    }
}