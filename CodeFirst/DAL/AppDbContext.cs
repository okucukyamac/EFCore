using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one-to-many
            //modelBuilder.Entity<Category>().HasMany(a => a.Products).WithOne(x => x.Category).HasForeignKey(a => a.CategoriId);

            //one-to-one
            //modelBuilder.Entity<Product>().HasOne(a => a.ProductFeature).WithOne(a => a.Product).HasForeignKey<ProductFeature>(a => a.ProductId);


            //one-to-one foreign key and primary key are same
            modelBuilder.Entity<Product>().HasOne(a => a.ProductFeature).WithOne(a => a.Product).HasForeignKey<ProductFeature>(a => a.Id);
        }


    }
}
