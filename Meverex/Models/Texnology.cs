
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meverex.Models
{
    public class Texnology
    {
       
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string BtnName { get; set; }

        [Required, MaxLength(50)]
        public string BtnUrl { get; set; }

        [Required, MaxLength(150)]
        public string Photo { get; set; }

         [Required, MaxLength(150)]
        public string Tittle { get; set; }

       [Required,Column(TypeName ="ntext")]
        public string Description { get; set; }

        [Required]
        public bool Status { get; set; }

    }
}