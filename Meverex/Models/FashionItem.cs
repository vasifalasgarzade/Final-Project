﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Meverex.Models
{
    public class FashionItem
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        [ MaxLength(100)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Required, MaxLength(200)]
        public string Tittle { get; set; }
        [Required, MaxLength(250)]
        public string Description { get; set; }
        [Required, Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    
    }
}