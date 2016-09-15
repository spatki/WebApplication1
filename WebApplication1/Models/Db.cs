using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Db : DbContext
    {
        public Db()
            : base("name=WebEntities")
        {
            Database.SetInitializer<Db>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<Person> mstr_client { get; set; }
    }
}