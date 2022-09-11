﻿// See https://aka.ms/new-console-template for more information
using EFCore.DataBaseFirst.DAL;
using Microsoft.EntityFrameworkCore;
DbContextInitializer.Build();
using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();
    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id}:{p.Name}-{p.Price}-{p.Stock}");
    });
}
