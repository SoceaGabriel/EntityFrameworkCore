using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }


        public DbSet<FluentBookDetail> FluentBookDetails { get; set; }
        public DbSet<FluentBook> FluentBooks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseSqlServer("Server=GABISOCEA;Database=EntityFrameworkTutorial;TrustServerCertificate=True;Trusted_Connection=True;")
            //   .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name } , LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //FluentBookDetail
            modelBuilder.Entity<FluentBookDetail>().ToTable("fluent_book_details");
            modelBuilder.Entity<FluentBookDetail>()
                .HasKey(u => u.FluentBookDetailId);
            modelBuilder.Entity<FluentBookDetail>()
                .Property(u => u.FluentBookDetailId)
                .HasColumnName("fluent_book_detail_id");
            modelBuilder.Entity<FluentBookDetail>()
                .Property(u => u.NumberOfChapters)
                .HasColumnName("no_of_chapters")
                .IsRequired();
            modelBuilder.Entity<FluentBookDetail>()
                .Property(u => u.NumberOfPages)
                .HasColumnName("no_of_pages");
            modelBuilder.Entity<FluentBookDetail>()
                .Property(u => u.Weight)
                .HasColumnName("weight");

            //FluentBook
            modelBuilder.Entity<FluentBook>().ToTable("fluent_book");
            modelBuilder.Entity<FluentBook>()
                .HasKey(u => u.FluentBookId);
            modelBuilder.Entity<FluentBook>()
                .Property(u => u.FluentBookId)
                .HasColumnName("fluent_book_id");
            modelBuilder.Entity<FluentBook>()
                .Property(u => u.ISBN)
                .HasColumnName("isbn")
                .HasMaxLength(20)
                .IsRequired();
            modelBuilder.Entity<FluentBook>()
                .Property(u => u.Price)
                .HasColumnName("price");
            modelBuilder.Entity<FluentBook>()
                .Ignore(u => u.PriceRange);

            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);

            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.AuthorId, u.BookId });

            modelBuilder.Entity<Book>().HasData(
            new Book
            {
                BookId = 1, 
                Title = "Arta de a vorbi convingator", 
                ISBN = "123456", 
                Price = 39, 
                PublisherId = 1
            },
            new Book
            {
                BookId = 2, 
                Title = "Legea atractiei", 
                ISBN = "123498", 
                Price = 35, 
                PublisherId = 2
            });

            modelBuilder.Entity<Publisher>().HasData(
            new Publisher
            {
                PublisherId = 1,
                Name = "Editura Litera",
                Location = "Iasi"
            },
            new Publisher
            {
                PublisherId = 2,
                Name = "Editura Curtea Veche",
                Location = "Bucuresti"
            });
        }
    }
}
