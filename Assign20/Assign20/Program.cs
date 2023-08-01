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
        static void Main(string[] args)
        {
            Library mgmt = new Library();

            do
            {
                Console.WriteLine("Choose operation");
                Console.WriteLine("1. Add Book\n2. View All Books\n3. Search by ID\n4. Search by Title\n5. Exit");
                int op;
                if (!int.TryParse(Console.ReadLine(), out op))
                {
                    Console.WriteLine("Invalid input. Please enter a valid operation number.");
                    continue;
                }

                switch (op)
                {
                    case 1:
                        {
                            Book newBook = new Book();
                            Console.WriteLine("Enter Book ID");
                            if (!int.TryParse(Console.ReadLine(), out int bookId))
                            {
                                Console.WriteLine("Invalid input. Book ID must be an integer.");
                                continue;
                            }
                            newBook.BookId = bookId;

                            Console.WriteLine("Enter Book Title");
                            newBook.Title = Console.ReadLine();

                            Console.WriteLine("Enter Book Author");
                            newBook.Author = Console.ReadLine();

                            Console.WriteLine("Enter Book Genre");
                            newBook.Genre = Console.ReadLine();

                            Console.WriteLine("Check Book Availability (true/false):");
                            if (!bool.TryParse(Console.ReadLine(), out bool isAvailable))
                            {
                                Console.WriteLine("Invalid input. Is Available must be either 'true' or 'false'.");
                                continue;
                            }
                            newBook.IsAvailable = isAvailable;

                            mgmt.AddBook(newBook);
                            break;
                        }
                    case 2:
                        {
                            mgmt.ViewAllBooks();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Book Id to search");
                            if (!int.TryParse(Console.ReadLine(), out int bookID))
                            {
                                Console.WriteLine("Invalid input. Book ID must be an integer.");
                                continue;
                            }
                            mgmt.SearchBookById(bookID);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter Book Title to search");
                            string bookTitle = Console.ReadLine();
                            mgmt.SearchBookByTitle(bookTitle);
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Exiting the management system....");
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid operation was chosen, Please try again!");
                            break;
                        }
                }
            } while (true);
        }
    }
}
