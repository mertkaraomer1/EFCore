﻿// See https://aka.ms/new-console-template for more information
using EFCore.CodeFirst;
using EFCore.CodeFirst.DAL;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

Initializer.Build();

using (var _context = new appDbContext())
{
    var category = _context.Categories.First(x => x.Name == "Defterler");
    var product = new Product() { Name = "Defter1", Price = 3000, Stock = 300, Barcode = 3111,CategoryId=category.Id };
    //var category=new Category() { Name="Defterler"};
    //category.Products.Add( new () { Name = "Defter1", Price = 3000, Stock = 300, Barcode = 311 });
    //category.Products.Add(new() { Name = "Defter2", Price = 1000, Stock = 100, Barcode = 111 });
    //var product=new Product() { Name="kalem2",Price=200,Stock=200,Barcode=321,Category=category};
    _context.Add(category);
    _context.SaveChanges();
    Console.WriteLine("kaydedildi");


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