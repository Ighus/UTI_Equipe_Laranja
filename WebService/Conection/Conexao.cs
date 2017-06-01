using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebService.Models;

namespace WebService.Conection
{
    public class Conexao : DbContext
    {
        public Conexao() : base("name=MinhaConexao")
        {
            Database.SetInitializer<Conexao>(null);
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