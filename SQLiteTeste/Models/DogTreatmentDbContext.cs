using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTeste.Models
{
    public class DogTreatmentDbContext : DbContext
    {
        public DogTreatmentDbContext(DbContextOptions options) : base(options) { }
        public DbSet<WaterControl> tbWater { get; set; }
        public DbSet<FoodControl> tbFood { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the first table for "tbWater"
            modelBuilder.Entity<WaterControl>().ToTable("tbWater");

            // Configure the second table for "tbFood"
            modelBuilder.Entity<FoodControl>().ToTable("tbFood");

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;
            }

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DatabaseTreatments.db;Cache=Shared");
            //optionsBuilder.UseSqlite("Data Source=.\\SQLiteTeste\\SQLiteTeste\\DatabaseTreatments.db;Cache=Shared");
            //optionsBuilder.UseSqlite(@"Data Source=.\\bin\\Degug\\DatabaseTreatments.db;Cache=Shared");
            //optionsBuilder.UseSqlite(@"Data Source=C:\\Users\\uliss\\source\\repos\\SQLiteTeste\\SQLiteTeste\\DatabaseTreatments.db;Cache=Shared");
            //optionsBuilder.UseSqlite("Data Source=" +
            //            Path.Combine(Directory.GetCurrentDirectory(), "DatabaseTreatments.db"));
        }
    }

}

