using System;
using System.Collections.Generic;
namespace Collections_6
{
    class Book
    {
        string author;
        string title;
        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
        }
        public override string ToString()
        {
            return string.Format($"'{title}' by {author}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // LIFO (Last In First Out)

            Stack<Book> books = new Stack<Book>();
            books.Push(new Book("Ian Griffiths", "Programming C# 8.0"));
            books.Push(new Book("Jon Skeet", "C# in Depth"));
            books.Push(new Book(" Andrew Troelsen", "Pro C# 7: With .NET and .NET Core"));
       
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine();
            Console.WriteLine($"Book on top - {books.Peek()}");
            Console.WriteLine($"Total books in a stack - {books.Count}");
            Console.WriteLine("Book reading order:");
            while (books.Count > 0)
            {
                Console.WriteLine(books.Pop());
            }
        }
    }
}