// See https://aka.ms/new-console-template for more information
using EFCore.CodeFirst;
using EFCore.CodeFirst.DAL;

using Microsoft.EntityFrameworkCore;
Initializer.Build();

using (var _context = new appDbContext())
{

    _context.Products.Add(new() { Name = "Silgi 1", Price = 100, Stock = 200, Barcode = 500 });
    _context.Products.Add(new() { Name = "Silgi 2", Price = 200, Stock = 300, Barcode = 510 });
    _context.Products.Add(new() { Name = "Silgi 3", Price = 300, Stock = 100, Barcode = 520 });
    //Console.WriteLine($"Context Id:{_context.ContextId}");

    _context.SaveChanges();
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
 
}