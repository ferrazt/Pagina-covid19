using COVID.Map;
using COVID.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace COVID.Context
{
    public class COVIDContext : DbContext
    {
        public COVIDContext() : base() { }
     
        
        
        public DbSet<VW02_COVID_ONLINE> VW02_COVID_ONLINE { get; set; }
        public DbSet<VW01_COVID_UF> VW01_COVID_UF { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VW01_COVID_UFMap());
            modelBuilder.ApplyConfiguration(new VW02_COVID_ONLINEMap());
            

            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DBCOVID"));
        }

    }
}
