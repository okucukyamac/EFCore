// See https://aka.ms/new-console-template for more information


using DatabaseFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

//using (var _context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(a =>
    {
        Console.WriteLine(a.Name+ " - " +a.Price + " - "+ a.Stock);
    });
    
}

Console.WriteLine("Hello, World!");
