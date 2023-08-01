using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFor20
{
    public class Library
    {
        /*books = new List<Book>()
        {

            new Book { BookId = 1, Title = "Gold D Roger", Author = "Eichiri Oda", Genre = "Shonen, Fantasy", IsAvailable=true },
            new Book { BookId = 2, Title = "Attack on titan", Author = "Isagai", Genre = "History, Adventure", IsAvailable=true},
            new Book { BookId = 3, Title = "Naruto Shippuden", Author = "Masashi Kishimoto", Genre = "Shonen, Adventure", IsAvailable=true },
            new Book { BookId = 3, Title = "DeathNote", Author = "JRR Tolein", Genre = "Fantasy, Adventure", IsAvailable=true },
            new Book { BookId = 4, Title = "", Author = "JRR Tolein", Genre = "Fantasy, Adventure", IsAvailable=true }
        };*/

        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ViewAllBooks()
        {
            Console.WriteLine("All Books in the Library:");
            foreach (var book in books)
            {
                Console.WriteLine($"Book ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, IsAvailable: {(book.IsAvailable ? "Yes" : "No")}");
            }
            Console.WriteLine();
        }

        public Book SearchBookById(int bookId)
        {
            return books.Find(b => b.BookId == bookId);
        }

        public Book SearchBookByTitle(string title)
        {
            return books.Find(b => b.Title.ToLower().Contains(title.ToLower()));
        }

    }
}
