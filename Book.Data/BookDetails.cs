using System.ComponentModel.DataAnnotations;
namespace Book.Data
{
    public class BookDetails
    {
        public string bookName { get; set; }
        public string authorName { get; set; }
        [Required]
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
