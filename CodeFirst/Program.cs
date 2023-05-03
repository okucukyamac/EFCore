
using CodeFirst;
using CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

Initializer.Build();

using (var _context = new AppDbContext())
{

    var category = new Category() { Name = "deftasdferler" };

    var products = new List<Product>() { new Product() { Name = "dee", Price = 200, Stock = 38, Barcode = 324 } };

    products.Add( new () { Name = "asdfdas", Price = 200, Stock = 38, Barcode = 324});

    category.Products = products;

    _context.Add(category);

    _context.SaveChanges();

}

