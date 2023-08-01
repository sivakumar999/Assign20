using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryFor20;

namespace Assign20
{
    internal class Program
    {
        static void Main()
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. View all books");
                Console.WriteLine("3. Search book by ID");
                Console.WriteLine("4. Search book by title");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter Book ID: ");
                        int bookId = int.Parse(Console.ReadLine());

                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Book Author: ");
                        string author = Console.ReadLine();

                        Console.Write("Enter Book Genre: ");
                        string genre = Console.ReadLine();

                        Book newBook = new Book(bookId, title, author, genre);
                        library.AddBook(newBook);

                        Console.WriteLine("Book added successfully!");
                        Console.WriteLine();
                        break;

                    case "2":
                        library.ViewAllBooks();
                        break;

                    case "3":
                        Console.Write("Enter Book ID to search: ");
                        int searchBookId = int.Parse(Console.ReadLine());
                        var foundBookById = library.SearchBookById(searchBookId);
                        if (foundBookById != null)
                        {
                            Console.WriteLine($"Book found:");
                            Console.WriteLine($"Book ID: {foundBookById.BookId}, Title: {foundBookById.Title}, Author: {foundBookById.Author}, Genre: {foundBookById.Genre}, IsAvailable: {(foundBookById.IsAvailable ? "Yes" : "No")}");
                        }
                        else
                        {
                            Console.WriteLine("Book not found with the given ID.");
                        }
                        Console.WriteLine();
                        break;

                    case "4":
                        Console.Write("Enter Book Title to search: ");
                        string searchTitle = Console.ReadLine();
                        var foundBookByTitle = library.SearchBookByTitle(searchTitle);
                        if (foundBookByTitle != null)
                        {
                            Console.WriteLine($"Book found:");
                            Console.WriteLine($"Book ID: {foundBookByTitle.BookId}, Title: {foundBookByTitle.Title}, Author: {foundBookByTitle.Author}, Genre: {foundBookByTitle.Genre}, IsAvailable: {(foundBookByTitle.IsAvailable ? "Yes" : "No")}");
                        }
                        else
                        {
                            Console.WriteLine("Book not found with the given title.");
                        }
                        Console.WriteLine();
                        break;

                    case "5":
                        Console.WriteLine("Exiting Library Management System. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }
    }
}
