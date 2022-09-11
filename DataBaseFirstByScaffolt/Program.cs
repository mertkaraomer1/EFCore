// See https://aka.ms/new-console-template for more information
using DataBaseFirstByScaffolt.Models;
using Microsoft.EntityFrameworkCore;


using (var context = new EFCoreDateBaseFirstDbContext())
{
    var products = await context.Products.ToListAsync();
    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id}:{p.Name}-{p.Price}-{p.Stock}");
    });
}