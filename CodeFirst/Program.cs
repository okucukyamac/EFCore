
using CodeFirst;
using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{



 

    _context.SaveChanges();

}

Console.WriteLine("Hello, World!");
