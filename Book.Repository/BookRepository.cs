using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Data;
namespace Book.Repository
{
    public static class BookRepository
    {
        public static List<BookDetails> books = new List<BookDetails>();
        static BookRepository()
        {
            BookRepository.AddBook();
        }
        public static void AddBook()
        {
            books.Add(new BookDetails("Siddhartha","Hermen Hesse",25));
            books.Add(new BookDetails("Five Point", "Chetan Bhagat", 26));
        }
        public static IEnumerable<BookDetails> GetBooks()
        {
            return books;
        }
        public static BookDetails FindBook(int id)
        {
            BookDetails book = new BookDetails();
            foreach(BookDetails bookDetails in books)
            {
                if(bookDetails.bookId==id)
                {
                    return bookDetails;
                }
            }
            return book;
        }
        public static void UpdateBook(int bookId, string bookName, string authorName)
        {
            BookDetails bookDetails = FindBook(bookId);
            books.Remove(bookDetails);
            books.Add(new BookDetails(bookName, authorName, bookId));
        }
        public static void DeleteBook(int bookId)
        {
            BookDetails bookDetails = FindBook(bookId);
            books.Remove(bookDetails);
        }
    }
}
