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
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }

        [Required, MaxLength(200)]
        public string Tittle { get; set; }
        [Required, MaxLength(400)]
        public string Description { get; set; }
        [Required, Column(TypeName = "date")]
        public DateTime Date { get; set; }
        public bool Status { get; set; }
       
      
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        
 





      
        public virtual  Category Category { get; set; }
        public  virtual Author Author { get; set; }
       









    }
}