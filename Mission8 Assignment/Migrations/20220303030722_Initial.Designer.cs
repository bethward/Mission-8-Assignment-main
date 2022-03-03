﻿// <auto-generated />
using BookProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookProject.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20220303030722_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("BookProject.Models.Book", b =>
                {
                    b.Property<long>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Classification")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("PageCount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 2L,
                            Author = "Doris Kearns Goodwin",
                            Category = "Biography",
                            Classification = "Non-Fiction",
                            ISBN = "978-0743270755",
                            PageCount = 944L,
                            Price = 14.579999923706055,
                            Publisher = "Simon & Schuster",
                            Title = "Team of Rivals"
                        },
                        new
                        {
                            BookId = 3L,
                            Author = "Laura Hillenbrand",
                            Category = "Historical",
                            Classification = "Non-Fiction",
                            ISBN = "978-0812974492",
                            PageCount = 538L,
                            Price = 13.329999923706055,
                            Publisher = "Random House",
                            Title = "Unbroken"
                        },
                        new
                        {
                            BookId = 4L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 5L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 6L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 7L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 8L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 9L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 10L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 11L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 12L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 13L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 14L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 15L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 16L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 17L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 18L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 19L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 20L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 21L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        },
                        new
                        {
                            BookId = 22L,
                            Author = "Victor Hugo",
                            Category = "Classic",
                            Classification = "Fiction",
                            ISBN = "978-0451419439",
                            PageCount = 1488L,
                            Price = 9.9499998092651367,
                            Publisher = "Signet",
                            Title = "Les Miserables"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
