using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.DAL
{
    public class appDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.Product_Id);
            //modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired().HasMaxLength (100);
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired().HasMaxLength(100).IsFixedLength();

           // modelBuilder.Entity<Product>().ToTable("ProductTBB", "productsTbb");
            base.OnModelCreating(modelBuilder);
        }
        //public override int SaveChanges()
        //{
        //    ChangeTracker.Entries().ToList().ForEach(e =>
        //    {
        //        if (e.Entity is Product p)
        //        {
        //            if (e.State == EntityState.Added)
        //            {
        //                p.CreatedDate = DateTime.Now;
        //            }
        //        }

        //    });
        //    return base.SaveChanges();
        //}
    }
}
