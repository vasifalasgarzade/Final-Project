using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Meverex.Models;

namespace Meverex.Data
{
    public class FinalDbMeverex :DbContext
    {
        public FinalDbMeverex(): base("FinalDbMeverex")
        {
        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Texnology> Texnologies { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
    }
  
}