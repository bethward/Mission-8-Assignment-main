using System;
using System.Linq;

namespace BookProject.Models
{
    public class EFBookRepository : IBookRepository
    {
      private BookContext context { get; set; }

      public EFBookRepository (BookContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;


        //adding functionality from IBookRepository
        public void SaveBook(Book b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Book b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Book b)
        {
            context.Remove(b);
            context.SaveChanges();
        }

    }
}
