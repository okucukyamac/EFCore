
using CodeFirst;
using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{

  

    var product = await _context.Products.ToListAsync();

    var deneme =  _context.Products.Find(10);

 

    _context.SaveChanges();

}

Console.WriteLine("Hello, World!");
