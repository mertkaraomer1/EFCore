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
        public DbSet<Category> Categories { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Initializer.Build();
            optionsBuilder.UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //////OneToOne
            //modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(x => x.Product).HasForeignKey<ProductFeature>(x => x.ProductRef_Id);
            //////OneToMany
            //modelBuilder.Entity<Category>().HasMany(x=>x.Products).WithOne(x => x.Category).HasForeignKey(x=>x.Category_Id);
            //////OneToOne2
            // modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(x => x.Product).HasForeignKey<ProductFeature>(x => x.Id);
            modelBuilder.Entity<Student>()
                .HasMany(x => x.Teachers)
                .WithMany(x => x.Students)
                .UsingEntity<Dictionary<string, object>>(
                "StudentTeacherManyToMany", x => x.HasOne<Teacher>()
                .WithMany().HasForeignKey("Teacher_Id")
                .HasConstraintName("FK_TeacherId"),x=>x.HasOne<Student>()
                .WithMany().HasForeignKey("Student_Id")
                .HasConstraintName("FK_StudentId"));
            //modelBuilder.Entity<Product>().HasKey(p => p.Product_Id);
            //modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired().HasMaxLength (100);
            //modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired().HasMaxLength(100).IsFixedLength();

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
