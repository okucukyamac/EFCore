
using CodeFirst;
using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{
    var category = new Category { Name = "deneme" };
    var product = new Product { Name = "Silgi", Price = 300, Stock = 32, Barcode = 342,Category=category };

    var feature = new ProductFeature { Color="deneme",Height=32,Width=32,Product=product};


    _context.Add(feature);

    _context.SaveChanges();

}

