
using System.ComponentModel.DataAnnotations;

namespace Meverex.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string HeaderLogo { get; set; }
        [Required, MaxLength(100)]
        public string FooterLogo { get; set; }
        [Required, MaxLength(200)]
        public string Tiitle { get; set; }
        
    }
}