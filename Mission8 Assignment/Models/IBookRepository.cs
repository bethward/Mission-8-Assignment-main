using System;
using System.Linq;

namespace BookProject.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }


        //included to allow CRUD from adimnistration end
        public void SaveBook(Book b);
        public void CreateBook(Book b);
        public void DeleteBook(Book b);
        
    } 
}
