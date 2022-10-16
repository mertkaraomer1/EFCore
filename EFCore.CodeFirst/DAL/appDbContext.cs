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
        //public DbSet<Insan> insans { get; set; }
        //public DbSet<ProductFull> productFulls  { get; set; }
        //public DbSet<Person> Persons { get; set; }
        //public DbSet<Manager> Managers { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> productFeatures { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<Teacher> Teachers { get; set; }
        //public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //trace
            //debug
            //ınformation
            //warning
            //error
            //critical
            Initializer.Build();
            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information).UseSqlServer(Initializer.Configuration.GetConnectionString("SqlCon"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasCheckConstraint("PriceDiscountCheck", "[Price]>[DiscountPrice]");
            ////////Index
            ////    _context.Products.Where(x => x.Name == "kalem1").Select(x => new { name = x.Name, price = x.Price, stock = x.Stock, barcode = x.Barcode });
            //modelBuilder.Entity<Product>().HasIndex(x => x.Name).IncludeProperties(x =>new { x.Price,x.Stock});
            ////////Column(TypeName)
            //modelBuilder.Entity<Product>().Property(x => x.Url).HasColumnType("varchar(500)");
            ////////UniCode
            //modelBuilder.Entity<Product>().Property(x=>x.Name).IsUnicode(false);//varchar
            //////NotMapped
            //modelBuilder.Entity<Product>().Ignore(x => x.Barcode);
            //////Keyless appdbcontext tarafı
            //modelBuilder.Entity<ProductFull>().HasNoKey();
            //////Owned Entity Types
            //modelBuilder.Entity<Manager>().OwnsOne(x => x.Person, p=>
            //{ p.Property(x => x.Name).HasColumnName("Name");
            //    p.Property(x => x.Surname).HasColumnName("Surname");
            //    p.Property(x => x.Age).HasColumnName("Age");
            //    });
            //modelBuilder.Entity<Employee>().OwnsOne(x => x.Person, p =>
            //{
            //    p.Property(x => x.Name).HasColumnName("Name");
            //    p.Property(x => x.Surname).HasColumnName("Surname");
            //    p.Property(x => x.Age).HasColumnName("Age");
            //});
            //TPT
            //modelBuilder.Entity<BasePerson>().ToTable("Persons");
            //modelBuilder.Entity<Employee>().ToTable("Employees");
            //modelBuilder.Entity<Manager>().ToTable("Managers");
            //modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(18, 2);
            ///////DatabaseGenerated Attribute
            //modelBuilder.Entity<Product>().Property(x => x.PriceKdv).HasComputedColumnSql("[Price]*[Kdv]");
            //modelBuilder.Entity<Product>().Property(x => x.PriceKdv).ValueGeneratedOnAdd();//ıdentity
            //modelBuilder.Entity<Product>().Property(x => x.PriceKdv).ValueGeneratedOnUpdate();//computed
            //modelBuilder.Entity<Product>().Property(x => x.PriceKdv).ValueGeneratedNever();//None
            ///////Relationships Delete Behaviors
            ////cascade
            //modelBuilder.Entity<Category>().HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Cascade);
            //////restrict
            //modelBuilder.Entity<Category>().HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.Restrict);
            //////SetNull
            // modelBuilder.Entity<Category>().HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId).OnDelete(DeleteBehavior.SetNull);
            //////OneToOne
            //modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(x => x.Product).HasForeignKey<ProductFeature>(x => x.ProductRef_Id);
            //////OneToMany
            //modelBuilder.Entity<Category>().HasMany(x=>x.Products).WithOne(x => x.Category).HasForeignKey(x=>x.Category_Id);
            //////OneToOne2
            // modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(x => x.Product).HasForeignKey<ProductFeature>(x => x.Id);
            //////ManyToMany
            //modelBuilder.Entity<Student>()
            //    .HasMany(x => x.Teachers)
            //    .WithMany(x => x.Students)
            //    .UsingEntity<Dictionary<string, object>>(
            //    "StudentTeacherManyToMany", x => x.HasOne<Teacher>()
            //    .WithMany().HasForeignKey("Teacher_Id")
            //    .HasConstraintName("FK_TeacherId"),x=>x.HasOne<Student>()
            //    .WithMany().HasForeignKey("Student_Id")
            //    .HasConstraintName("FK_StudentId"));
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
