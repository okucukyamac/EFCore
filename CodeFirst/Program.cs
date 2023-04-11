
using CodeFirst;
using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext)
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(a =>
    {
        Console.WriteLine(a.Name);
    });
}

Console.WriteLine("Hello, World!");
