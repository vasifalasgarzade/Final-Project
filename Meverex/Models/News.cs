using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Meverex.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Photo { get; set; }
        [Required, MaxLength(100)]
        public string Tittle { get; set; }

        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
       
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
      



      
        public Category Category { get; set; }
        public Author Author { get; set; }
        








    }
}