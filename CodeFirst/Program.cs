
using CodeFirst;
using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{

    _context.Products.Add(new() { Name = "a2", Price = 23, Stock = 32, Barcode = 2398 });
    _context.Products.Add(new() { Name = "a3", Price = 23, Stock = 32, Barcode = 2398 });
    _context.Products.Add(new() { Name = "a4", Price = 23, Stock = 32, Barcode = 2398 });


    var product = await _context.Products.ToListAsync();

    var deneme =  _context.Products.Find(10);

 

    _context.SaveChanges();

}

Console.WriteLine("Hello, World!");
