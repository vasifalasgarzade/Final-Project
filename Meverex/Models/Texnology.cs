
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Meverex.Models
{
    public class Texnology
    {
       
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string BtnName { get; set; }

        [ MaxLength(50)]
        public string BtnUrl { get; set; }

        [ MaxLength(150)]
        public string Photo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }

        [Required, MaxLength(250)]
        public string Tittle { get; set; }

       [Required,Column(TypeName ="ntext")]
        public string Description { get; set; }

        [Required, Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public bool Status { get; set; }
      

    }
}