using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Data
{
    public class BookDetails
    {
        public string bookName { get; set; }
        public string authorName { get; set; }
        public int bookId { get; set; }
        public BookDetails(string bookName,string authorName,int bookId)
        {
            this.bookName = bookName;
            this.authorName = authorName;
            this.bookId = bookId;
        }
        public BookDetails()
        {

        }
    }
}
