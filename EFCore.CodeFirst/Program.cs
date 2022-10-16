// See https://aka.ms/new-console-template for more information
using EFCore.CodeFirst;
using EFCore.CodeFirst.DAL;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Drawing;
using System.Security.Cryptography;
using System.Xml;

Initializer.Build();

using (var _context = new appDbContext())
{
    //////Full Outher Join
    //var resultLeft = await (from p in _context.Products
    //                        join pf in _context.productFeatures on p.Id equals pf.Id into pflist
    //                        from pf in pflist.DefaultIfEmpty()
    //                        select new
    //                        {
    //                            id=p.Id,
    //                            nameof=p.Name,
    //                            color=pf.Color
    //                        }).ToListAsync();
    ////query syntax denir.
    //var resultRight = await (from pf in _context.productFeatures
    //                        join p in _context.Products on pf.Id equals p.Id into plist
    //                        from p in plist.DefaultIfEmpty()
    //                        select new
    //                        {
    //                            id = p.Id,
    //                            nameof = p.Name,
    //                            color = pf.Color
    //                        }).ToListAsync();

    //var outherJoin=resultLeft.Union(resultRight);
    //Console.WriteLine("");

    //////Left Join
    //var result = await (from p in _context.Products
    //                    join pf in _context.productFeatures on p.Id equals pf.Id
    //                    into pflist
    //                    from pf in pflist.DefaultIfEmpty()
    //                    select new
    //                    {
    //                        ProductName = p.Name,
    //                        ProductColor = pf.Color,
    //                        PruductWidth = (int?)pf.Width == null ? 5 : pf.Width

    //                    }).ToListAsync();
    //Console.WriteLine("");

    //////Right Join
    //var Rightresult = await (from pf in _context.productFeatures
    //                    join p in _context.Products on pf.Id equals p.Id
    //                    into plist
    //                    from p in plist.DefaultIfEmpty()
    //                    select new
    //                    {
    //                        ProductName = p.Name,
    //                        PruductPrice = (decimal?)p.Price,
    //                        ProductColor = pf.Color,
    //                        PruductWidth = pf.Width 

    //                    }).ToListAsync();
    //Console.WriteLine("");

    //////2'li Join
    /*var result = _context.Categories.Join(_context.Products, x => x.Id, y => y.CategoryId, (c, p) => p).ToList();*/ //new
                                                                                                                      //{
                                                                                                                      //    CategoryName = c.Name,
                                                                                                                      //    ProductName = p.Name,
                                                                                                                      //    PruductPrice = p.Price,
                                                                                                                      //}).ToList();
                                                                                                                      //var result2=(from c in _context.Categories join p in _context.Products on c.Id equals p.CategoryId select new
                                                                                                                      //{
                                                                                                                      //    CategoryName=c.Name,
                                                                                                                      //    ProductName = p.Name,
                                                                                                                      //     PruductPrice = p.Price,
                                                                                                                      //}).ToList();
                                                                                                                      //Console.WriteLine("");

    //////3'lü Join
    ////method Syntax denir
    //var result =_context.Categories
    //.Join(_context.Products,c=>c.Id,p=>p.CategoryId,(c,p)=>new {c,p})
    //.Join(_context.productFeatures, x => x.p.Id, y => y.Id, (c, pf) => new
    //{
    //    CategoryName = c.c.Name,
    //       ProductName = c.p.Name,
    //        PruductFeature= pf.Color

    //}).ToList();

    //Console.WriteLine("");
    //var result2 =(from c in _context.Categories
    //             join p in _context.Products on c.Id equals p.CategoryId
    //             join pf in _context.productFeatures on p.Id equals pf.Id
    //             select new 
    //             {
    //                 c,p,pf
    //                 //CategoryName = c.Name,
    //                 // ProductName = p.Name,
    //                 //PruductFeature= pf.Color

    //             }).ToList();
    //Console.WriteLine("");
    //var category = new Category() { Name = "Kalemler" };
    //category.Products.Add(new()
    //{
    //    Name = "Kalem1",
    //    Price = 100,
    //    Stock = 100,
    //    Barcode = 111,
    //    ProductFeature = new
    //    ProductFeature()
    //    { Color = "red", Height = 100, Width = 100 }
    //});
    //category.Products.Add(new()
    //{
    //    Name = "Kalem2",
    //    Price = 100,
    //    Stock = 100,
    //    Barcode = 111,
    //    ProductFeature = new
    //    ProductFeature()
    //    { Color = "blue", Height = 100, Width = 100 }
    //});
    //_context.Categories.Add(category);
    //_context.SaveChanges();
    //Console.WriteLine("kaydedildi");

    //////Client vs Server Evaluation
    ////var persons=_context.Persons.ToList().Where(x=> FormatPhone(x.Phone)== "05432245212").ToList();
    //var persons = _context.Persons.ToList().Select(x => new {personname=x.Name,personphone=FormatPhone(x.Phone)}).ToList();
    ////_context.Persons.Add(new Person() { Name = "mert", Phone = "05432245212" });
    ////_context.Persons.Add(new Person() { Name = "Caner", Phone = "05433345412" });
    //string FormatPhone(string Phone)
    //{
    //    return Phone.Substring(1, Phone.Length - 1);
    //}

    //////Index
    //_context.Products.Where(x => x.Name == "kalem1").Select(x => new { name = x.Name, price = x.Price, stock = x.Stock, barcode = x.Barcode });
    // _context.Products.Add(new() { Name = "KALEM1", Price = 100, DiscountPrice = 180, Barcode = 123, Stock = 23, Url = "ABA" });


    //////Keyless
    //    var insans = _context.insans.ToList();
    //    //_context.insans.Add(new Insan() { Name = "mert", SurName = "karaömer" });//pk yoksa işlemi gerçekleştiremiyoruz hatası verdi
    //    var productFulls = _context.productFulls.FromSqlRaw(@"select p.Id, c.Name'CAtegoryName' ,p.Name , p.Price,pf.Height from products.ProductTb p
    //join productFeatures pf on p.Id=pf.Id
    //join Categories c on p.CategoryId=c.Id").ToList();
    //var category = new Category() { Name = "Kalemler" };
    //category.Products.Add(new() { Name = "Kalem1", Price = 100, Stock = 100, Barcode = 111, ProductFeature = new 
    //    ProductFeature() { Color = "red", Height = 100, Width = 100 } });
    //category.Products.Add(new() { Name = "Kalem2", Price = 100, Stock = 100, Barcode = 111, ProductFeature = new 
    //    ProductFeature() { Color = "blue", Height = 100, Width = 100 } });
    //_context.Categories.Add(category);



    //////TPH(Table-Per-Hierarchy)
    //_context.Managers.Add(new Manager() { Name = "mert", Surname = "karaömer", Age = 26, Grade = 1 });
    //_context.Employees.Add(new Employee() { Name = "mert", Surname = "karaömer", Age = 26, Salary = 10000 });
    //_context.Persons.Add(new Manager() { Name = "mert", Surname = "karaömer", Age = 26, Grade = 1 });
    //_context.Persons.Add(new Employee() { Name = "mert", Surname = "karaömer", Age = 26, Salary = 10000 });
    //var manegers = _context.Managers.ToList();
    //var employees = _context.Employees.ToList();
    //var persons = _context.Persons.ToList();
    //persons.ForEach(p =>
    //{
    //    switch (p)
    //    {
    //        case Manager manager:
    //            Console.WriteLine($"manager entity:{manager.Grade}");
    //            break;
    //        case Employee employee:
    //            Console.WriteLine($"employee entity:{employee.Salary}");
    //            break;
    //        default:
    //            break;
    //    }
    //});


    //////TPT(Table-Per-Type)
    //_context.Managers.Add(new Manager() { Name = "mert", Surname = "karaömer", Age = 26, Grade = 1 });
    //_context.Employees.Add(new Employee() { Name = "mert", Surname = "karaömermerr", Age = 26, Salary = 10000 });
    //_context.Persons.Add(new Manager() { Name = "m1", Surname = "k1", Age = 26, Grade = 1 });
    //_context.Persons.Add(new Employee() { Name = "m2", Surname = "k2", Age = 26, Salary = 10000 });
    //var manegers = _context.Managers.ToList();
    //var employees = _context.Employees.ToList();
    //var persons = _context.Persons.ToList();
    //persons.ForEach(p =>
    //{
    //    switch (p)
    //    {
    //        case Manager manager:
    //            Console.WriteLine($"manager entity:{manager.Grade}");
    //            break;
    //        case Employee employee:
    //            Console.WriteLine($"employee entity:{employee.Salary}");
    //            break;
    //        default:
    //            break;
    //    }
    //});



    //////LazyLoadind
    //var category =await _context.Categories.FirstAsync();
    //var product =  category.Products;
    //Console.WriteLine("işlem bitti");
    //////ExplicitLoding
    //var category = _context.Categories.First();
    //var product = _context.Products.First();
    //if (true)
    //{
    //    _context.productFeatures.Where(x => x.Id == product.Id).First();
    //    _context.Entry(product).Reference(x => x.ProductFeature).Load();
    //    _context.Entry(category).Collection(x => x.Products).Load();
    //    category.Products.ForEach(x =>
    //    {
    //        Console.WriteLine(x.Name);
    //    });
    //}




    //////EagerLoding
    //var category=new Category() { Name="Kalemler"};
    //category.Products.Add(new() { Name = "Kalem1", Price = 100, Stock = 100, Barcode = 111, ProductFeature = new ProductFeature() { Color = "red", Height = 100, Width = 100 } });
    //category.Products.Add(new() { Name = "Kalem2", Price = 100, Stock = 100, Barcode = 111, ProductFeature = new ProductFeature() { Color = "blue", Height = 100, Width = 100 } });
    //_context.AddAsync(category);
    //var categorywithProducts = _context.Categories.Include(x => x.Products).ThenInclude(x=>x.ProductFeature).First();
    //categorywithProducts.Products.ForEach(Product=>
    //{
    //    Console.WriteLine($"{categorywithProducts.Name}-{Product.Name}-{Product.ProductFeature.Width}");
    //});
    //var product = _context.Products.Include(x => x.ProductFeature).Include(X => X.Category).First(); ;


    //_context.Products.Add(new() { Name="kalem1",Price=100,Stock=1,Barcode=20,Kdv=18});
    //var category = _context.Categories.First();
    //var product = _context.Products.Where(x => x.CategoryId == category.Id).ToList();
    //_context.RemoveRange(product);
    //_context.Categories.Remove(category);

    //var category = new Category()
    //{
    //    Name = "Kalemler",
    //    Products = new List<Product>()
    //{
    //    new(){ Name = "kalem100", Price = 3000, Stock = 300, Barcode = 3111 },
    //    new(){ Name = "kalem200", Price = 3000, Stock = 300, Barcode = 3111 },
    //    new(){ Name = "kalem300", Price = 3000, Stock = 300, Barcode = 3111 }

    //}
    //};
    //_context.Add(category);


    //var student=new Student() { Name="Mert",Age=26};
    //student.Teachers.Add(new() { Name = "Özge" });
    //student.Teachers.Add(new() { Name = "Can" });
    //_context.Add(student);

    //var teacher = new Teacher()
    //{
    //    Name = "Mert ",
    //    Students = new List<Student>()
    //    {
    //     new Student(){Name="murat",Age=24 },
    //     new Student(){Name="hasan",Age=25} 
    //    }
    //};
    //_context.Add(teacher);


    //////ManyToMany
    //var teacher = _context.Teachers.First(x => x.Name == "Özge");
    //teacher.Students.AddRange(new List<Student>{new () { Name = "okan", Age = 32 },
    //    new() { Name ="oğulcan",Age=25 }});




    //product->parent
    //productfeature->child
    //var category = _context.Categories.First(x => x.Name == "Silgiler");
    //var product = new Product
    //{
    //    Name = "silgi10",
    //    Price = 102,
    //    Stock = 501,
    //    Barcode = 442,
    //    Category = category
    //};
    //ProductFeature = new() { Color = "white", Height = 100, Width = 200 } };
    //ProductFeature productFeature = new ProductFeature() { Color = "blue", Width = 200, Height = 200, Product = product };
    //_context.Products.Add(product);
    //_context.productFeatures.Add(productFeature);
    //_context.SaveChanges();
    //var category = _context.Categories.First(x => x.Name == "Defterler");
    //var product = new Product() { Name = "Defter1", Price = 3000, Stock = 300, Barcode = 3111,CategoryId=category.Id };
    //var category=new Category() { Name="Defterler"};
    //category.Products.Add( new () { Name = "Defter1", Price = 3000, Stock = 300, Barcode = 311 });
    //category.Products.Add(new() { Name = "Defter2", Price = 1000, Stock = 100, Barcode = 111 });
    //var product=new Product() { Name="kalem2",Price=200,Stock=200,Barcode=321,Category=category};
    //_context.Add(category);
    //_context.SaveChanges();
    // Console.WriteLine("kaydedildi");


    // var products =await _context.Products.Where(x => x.Id <5&&x.Name=="kalem 200"||x.Stock>200).ToListAsync();
    //var products = await _context.Products.FirstAsync(x => x.Id == 5);
    //var products1 = await _context.Products.SingleAsync(x => x.Id == 4);
    //var products2 = await _context.Products.FindAsync(10 );
    //var product = _context.Products.ToList();
    //product.ForEach(p =>
    //{
    //    p.Stock += 100;
    //});
    //_context.ChangeTracker.Entries().ToList().ForEach(e =>
    //{
    //    if (e.Entity is Product p)
    //    {
    //        Console.WriteLine(e.State);
    //    }
    //var product =_context.Products.First();
    //product.Name = "dolma kalem 100";
    //product.Price = 200;
    //_context.Update(product);


    //_context.Products.Add(new() { Name = "Silgi 1", Price = 100, Stock = 200, Barcode = 500 });
    //_context.Products.Add(new() { Name = "Silgi 2", Price = 200, Stock = 300, Barcode = 510 });
    //_context.Products.Add(new() { Name = "Silgi 3", Price = 300, Stock = 100, Barcode = 520 });
    //Console.WriteLine($"Context Id:{_context.ContextId}");

    //_context.SaveChanges();
    // var product=_context.Products.First(x=>x.Id==5);
    // _context.Update(new Product { Name = "Defter", Price = 500, Stock = 500, Barcode = 500 });
    //var product=await _context.Products.FirstAsync();
    // Console.WriteLine($"ilk state:{_context.Entry(product).State}");
    // _context.Entry(product).State = EntityState.Detached;

    // Console.WriteLine($"son state:{_context.Entry(product).State}");
    // product.Name="kalem 2000";

    //_context.Entry(newProduct).State = EntityState.Added;
    // await _context.AddAsync(newProduct);

    //await _context.SaveChangesAsync();
    //Console.WriteLine($"SaveChance state:{_context.Entry(product).State}");


    //var products = await _context.Products.ToListAsync();


    // products.ForEach(p =>
    //{
    //p.Stock += 100;
    //var state=_context.Entry(p).State;
    //Console.WriteLine($"{p.Id}:{p.Name}-{p.Price}-{p.Stock} state:{state}");

    //});

    //}) ;
    //}
} 