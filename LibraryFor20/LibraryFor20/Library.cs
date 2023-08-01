using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFor20
{
    public class Library
    {
        List<Book> books;
        public Library()
        {
            books = new List<Book>()
            {
                
                new Book { BookId = 1, Title = "Gold D Roger", Author = "Eichiri Oda", Genre = "Shonen, Fantasy", IsAvailable=true },
                new Book { BookId = 2, Title = "Attack on titan", Author = "Isagai", Genre = "History, Adventure", IsAvailable=true},
                new Book { BookId = 3, Title = "Naruto Shippuden", Author = "Masashi Kishimoto", Genre = "Shonen, Adventure", IsAvailable=true },
                new Book { BookId = 3, Title = "DeathNote", Author = "JRR Tolein", Genre = "Fantasy, Adventure", IsAvailable=true },
                new Book { BookId = 4, Title = "", Author = "JRR Tolein", Genre = "Fantasy, Adventure", IsAvailable=true }
            };
        }
        public void AddBook(Book book)
        {
            books.Add(book);
            this.ViewAllBooks();
        }
        public void ViewAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"Book ID: \t{book.BookId}");
                Console.WriteLine($"Book Title: \t{book.Title}");
                Console.WriteLine($"Book Author: \t{book.Author}");
                Console.WriteLine($"Book Genre: \t{book.Genre}");
                Console.WriteLine($"Book is available: \t{book.IsAvailable}");
                Console.WriteLine();
            }
        }
        public void SearchBookById(int bookId)
        {
            var book = books.Find(b => b.BookId == bookId);
            if (book != null)
            {
                Console.WriteLine($"Book ID: \t{book.BookId}");
                Console.WriteLine($"Book Title: \t{book.Title}");
                Console.WriteLine($"Book Author: \t{book.Author}");
                Console.WriteLine($"Book Genre: \t{book.Genre}");
                Console.WriteLine($"Book is available: \t{book.IsAvailable}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Book Not Found");
            }
        }
        public void SearchBookByTitle(string title)
        {
            var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                Console.WriteLine($"Book ID: \t{book.BookId}");
                Console.WriteLine($"Book Title: \t{book.Title}");
                Console.WriteLine($"Book Author: \t{book.Author}");
                Console.WriteLine($"Book Genre: \t{book.Genre}");
                Console.WriteLine($"Book is available: \t{book.IsAvailable}");
            }
            else
            {
                Console.WriteLine("Book Not Found");
            }
        }
    }
}
