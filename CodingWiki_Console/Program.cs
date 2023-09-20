
using CodingWiki_DataAccess.Data;
using CodingWiki_DataAccess.Migrations;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

/*using (ApplicationDbContext context = new())
{
    context.Database.EnsureCreated();
    if(context.Database.GetPendingMigrations().Count() > 0)
    {
        context.Database.Migrate();
    }
}*/

//GetAllBooks();
//GetBook();
//AddBook();

/*void GetAllBooks()
{
    using var context = new ApplicationDbContext();
    var books = context.Books.ToList();
    foreach(var book in books)
    {
        Console.WriteLine(book.Title + " " + book.ISBN);
    }
}

void GetBook()
{
    using var context = new ApplicationDbContext();
    var book = context.Books.Single(); //.FirstOrDefault(u => u.Title.Equals("Psihologia - Foarte scurta introducere"));
    Console.WriteLine(book.Title + " " + book.ISBN);
}

void AddBook()
{
    using var context = new ApplicationDbContext();
    Book book = new Book
    {
        ISBN = "5463454",
        Price = 25,
        PriceRange = "20-30",
        PublisherId = 1,
        Title = "Psihologia - Foarte scurta introducere"
    };
    context.Books.Add(book);
    context.SaveChanges();
}*/