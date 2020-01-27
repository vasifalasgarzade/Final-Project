
using System.ComponentModel.DataAnnotations;

namespace Meverex.Models
{
    public class SocialLink
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Url { get; set; }

        [Required, MaxLength(100)]
        public string Icon { get; set; }
        public int Orderby { get; set; }
      



    }
}