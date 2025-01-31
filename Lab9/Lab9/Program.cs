using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookStore store = new BookStore("Book Store");
            Book book1 = new Book(100, new List<string> { "Author1", "Author2" }, 10, "Book1", "Genre1");
            Book book2 = new Book(200, new List<string> { "Author3", "Author4" }, 20, "Book2", "Genre2");
            Book book3 = new Book(300, new List<string> { "Author5", "Author6" }, 30, "Book3", "Genre3");
            store.AddBook(book1);
            store.AddBook(book2);
            store.AddBook(book3);
            store.DisplayBooks();
            store.RemoveAuthorFromBook("Book1", "Author1");
            store.DisplayBooks();
            store.Discount(10);
            store.DisplayBooks();
            store.DisplayBooksOfAuthor("Author3");
        }
    }
}
