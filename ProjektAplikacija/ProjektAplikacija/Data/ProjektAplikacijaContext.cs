using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjektAplikacija.Data
{
    public class ProjektAplikacijaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProjektAplikacijaContext() : base("name=ProjektAplikacijaContext")
        {
        }

        public System.Data.Entity.DbSet<ProjektAplikacija.Models.filmovi> filmovis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ProjektAplikacijaContext>(null);
           // Database.SetInitializer(new DropCreateDatabaseAlways<ProjektAplikacijaContext>());
        }

        public System.Data.Entity.DbSet<ProjektAplikacija.Models.film> films { get; set; }
    }
}
