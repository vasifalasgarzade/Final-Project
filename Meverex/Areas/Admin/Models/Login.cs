using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Meverex.Areas.Admin.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Məçburidir")]
        [MaxLength(50, ErrorMessage = "En cox 50 xarakter")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Məçburidir")]
        [MaxLength(50, ErrorMessage = "En cox 50 xarakter")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}