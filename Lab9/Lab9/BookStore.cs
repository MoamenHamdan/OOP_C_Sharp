using System;
using System.Collections.Generic;

namespace Lab9
{
    internal class BookStore
    {
        private string name;
        private List<Book> books;

        public BookStore(string name)
        {
            this.name = name;
            this.books = new List<Book>();
        }

        public bool AddBook(Book book)
        {
            if (books.Count < 200)
            {
                books.Add(book);
                return true;
            }
            return false;
        }

        public int GetNumberOfBooks()
        {
            return books.Count;
        }

        public bool RemoveAuthorFromBook(string bookName, string author)
        {
            foreach (var book in books)
            {
                if (book.Name == bookName)
                {
                    return book.removeauthor(author);
                }
            }
            return false;
        }

        public void Discount(double percentage)
        {
            foreach (var book in books)
            {
                book.Price -= (book.Price * percentage / 100);
            }
        }

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public void DisplayBooksOfAuthor(string author)
        {
            foreach (var book in books)
            {
                if (book.checkAuthor(author))
                {
                    Console.WriteLine(book.ToString());
                }
            }
        }

        public void DisplayBooksOfGenre(string genre)
        {
            foreach (var book in books)
            {
                if (book.Genre == genre)
                {
                    Console.WriteLine(book.ToString());
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Bookstore: " + Name);
            Console.WriteLine("Number of books: " + GetNumberOfBooks());
            DisplayBooks();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
