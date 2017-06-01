using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WebServiceLaranja.Models;


namespace WebServiceLaranja.Connect
{
    public class MinhaConexao : DbContext
    {
        public MinhaConexao() : base("name=MinhaConexao")
        {
            Database.SetInitializer<MinhaConexao>(null);
        }

        public DbSet<temp_press> temp_press { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}