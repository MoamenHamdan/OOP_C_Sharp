using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Book
    {
        private static int lastId = 0;  
        private int id;
        private int numberOfPages;
        private string name;
        private string genre;
        private List<string> authors;
        private double price;

        public static int nbrOfBooks { get; private set; } 

        public Book()
        {
            lastId++;  
            this.id = lastId;
            this.numberOfPages = 0;
            this.authors = new List<string>();
            this.price = 0;
            this.name = " ";
            this.genre = " ";
            nbrOfBooks++;  
        }

        public Book(int numberOfPages, List<string> authors, double price, string name, string genre)
        {
            lastId++;  
            this.id = lastId;
            this.numberOfPages = numberOfPages;
            this.authors = new List<string>(authors);
            this.price = price;
            this.name = name;
            this.genre = genre;
            nbrOfBooks++;
        }

        public void addAuthor(string author)
		{
            authors.Add(author);
        }
		public bool removeauthor(string author)
		{
            return authors.Remove(author);
        }
        public override string ToString()
        {
            return "ID: " + id + " Name: " + name + " Genre: " + genre + " Number of pages: " + numberOfPages + " Authors: " + string.Join(", ", authors) + " Number of books: " + nbrOfBooks + " Price: " + price;
        }

		public bool checkAuthor(string author)
		{
            return authors.Contains(author);
        }

        public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public List<string> Authors
        {
			get { return authors; }
			set { authors = value; }
		}

		public string Genre
		{
			get { return genre; }
			set { genre = value; }
		}

		public string  Name
		{
			get { return name; }
			set { name = value; }
		}


		public int NumberOfPages
        {
			get { return numberOfPages; }
			set { numberOfPages = value; }
		}


		public int ID
		{
			get { return id; }
			set { id = value; }
		}

	}

   
}
