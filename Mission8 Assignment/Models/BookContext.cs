using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BookProject.Models
{
    public partial class BookContext : DbContext
    {
        //public BookContext()
        //{
        //}

        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchase { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source = AmazonBook.sqlite");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.BookId);

                entity.Property(e => e.BookId);

                entity.Property(e => e.Author).IsRequired();

                entity.Property(e => e.Publisher).IsRequired();

                entity.Property(e => e.ISBN).IsRequired();

                entity.Property(e => e.Classification).IsRequired();

                entity.Property(e => e.Category).IsRequired();

                entity.Property(e => e.PageCount).IsRequired();

                entity.Property(e => e.Price).IsRequired();
            });

            modelBuilder.Entity<Book>().HasData(

                    new Book
                    {
                        BookId = 1,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 2,
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        PageCount = 944,
                        Price = 14.58f,
                    },

                    new Book
                    {
                        BookId = 3,
                        Title = "Unbroken",
                        Author = "Laura Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        PageCount = 538,
                        Price = 13.33f,
                    },

                    new Book
                    {
                        BookId = 4,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 5,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 6,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 7,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 8,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 9,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 10,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 11,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 12,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 13,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 14,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 15,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 16,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 17,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 18,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 19,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 20,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 21,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    },

                    new Book
                    {
                        BookId = 22,
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageCount = 1488,
                        Price = 9.95f,
                    }
                );

            OnModelCreatingPartial(modelBuilder);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
