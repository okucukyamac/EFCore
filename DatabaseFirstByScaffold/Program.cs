// See https://aka.ms/new-console-template for more information
using DatabaseFirstByScaffold.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

using (var dbContext = new EFCoreDatabaseFirstDbContext())
{
    var products = await dbContext.Products.ToListAsync();

    products.ForEach(a =>
    {
        Console.WriteLine(a.Name + " - " + a.Price + " - " + a.Stock);
    });

}