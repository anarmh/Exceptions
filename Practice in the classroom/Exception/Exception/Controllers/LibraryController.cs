using Exception.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Exception.LibraryController
{
    public class LibraryController
    {
        public static void GetAll()
        {
            var libraries = Add();
            foreach (var library in libraries)
            {
                foreach (var book in library.Books)
                {
                    Console.WriteLine(book.Name+ " "+ book.Author);
                }
            }
        }
        public static List<Book> GetAllBooksbyLibrary(Predicate<Book> predicate) 
        { 
             var books = GetAllBooks();
            return books.FindAll(predicate);
        }

        private static List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();
            Book book1 = new Book()
            {
                Name = "Yeddi Gozel",
                Author = "Nizami",
                LibraryId = 1
            };
            Book book2 = new Book()
            {
                Name = "Leyli ve Mecnun",
                Author = "Nizami",
                LibraryId = 1
            };
            Book book3 = new Book()
            {
                Name = "Shikayetname",
                Author = "Fuzuli",
                LibraryId = 2
            };
            Book book4 = new Book()
            {
                Name = "Ferhad ve Shirin",
                Author = "Fuzuli",
                LibraryId = 2
            };
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            return books;
        }




        private static List<Library> Add()
        {
           


            Book book1 = new Book()
            {
                Name = "Yeddi Gozel",
                Author = "Nizami",
                LibraryId = 1
            };
            Book book2 = new Book()
            {
                Name = "Leyli ve Mecnun",
                Author = "Nizami",
                LibraryId = 1
            };
            Book book3 = new Book()
            {
                Name = "Shikayetname",
                Author = "Fuzuli",
                LibraryId = 2
            };
            Book book4 = new Book()
            {
                Name = "Ferhad ve Shirin",
                Author = "Fuzuli",
                LibraryId=2
            };

            List<Book> books1 = new List<Book>() { book1,book2 };

            List<Book> books2 = new List<Book>() { book3, book4 };


            Library library1 = new Library()
            {
                Id = 1,
                Name = "Axundov",
                Books = books1
                
            };
            Library library2 = new Library()
            {
                Id = 2,
                Name = "Cefer Cabbarli",
                Books = books2
            };

            List<Library> libraries = new List<Library>();

            libraries.Add(library1);
            libraries.Add(library2);

            return libraries;
        }
    }
}
