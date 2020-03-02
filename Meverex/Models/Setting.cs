
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Meverex.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string HeaderLogo { get; set; }
        [NotMapped]
        public HttpPostedFileBase PhotoUpload { get; set; }
        [Required, MaxLength(100)]
        public string FooterLogo { get; set; }
        [Required, MaxLength(200)]
        public string Tiitle { get; set; }
        public bool Status { get; set; }



    }
}