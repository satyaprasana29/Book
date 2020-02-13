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
    }
}
