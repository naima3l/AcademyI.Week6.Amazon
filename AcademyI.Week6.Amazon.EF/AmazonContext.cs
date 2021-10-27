using AcademyI.Week6.Amazon.CORE;
using AcademyI.Week6.Amazon.EF.Configurations;
using Microsoft.EntityFrameworkCore;
using System;

namespace AcademyI.Week6.Amazon.EF
{
    public class AmazonContext : DbContext
    {
        public DbSet<Prodotto> Prodotti { get; set; }

        public AmazonContext()
        {

        }

        public AmazonContext(DbContextOptions<AmazonContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Amazon; Trusted_Connection = True;");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Prodotto>(new ProdottoConfiguration());
        }
    }
}
