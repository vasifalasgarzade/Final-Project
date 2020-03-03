using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meverex.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [MaxLength(100)]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [Column(TypeName = "ntext")]
        public string Desc { get; set; }

        [Required, Column(TypeName = "date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public bool Status { get; set; }
    }
}