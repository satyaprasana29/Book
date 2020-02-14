using System.Collections.Generic;
using System.Web.Mvc;
using Book.Repository;
using Book.Data;
namespace Book.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<BookDetails> bookDetails = BookRepository.GetBooks();
            return View(bookDetails);
        }
        //public ActionResult DataPassing()
        //{
        //    IEnumerable<BookDetails> bookDetails = BookRepository.GetBooks();
        //    ViewBag.Books = bookDetails;
        //    return View(bookDetails);
        //}
        //public ActionResult Viewdata()
        //{
        //    IEnumerable<BookDetails> bookDetails = BookRepository.GetBooks();
        //    ViewData["book"] = bookDetails;
        //    return View();
        //}
        //public ActionResult TempDataCall()
        //{
        //    IEnumerable<BookDetails> bookDetails = BookRepository.GetBooks();
        //    TempData["books"] = bookDetails;
        //    return RedirectToAction("TempDataResult");
        //}
        //public ActionResult TempDataResult()
        //{
        //    return View();
        //}
        [HttpGet]
        public ActionResult Create()
        {
            return View("CreateView");
        }
        [HttpPost]
        public ActionResult Create(BookDetails book)
        {
            BookRepository.books.Add(book);
            TempData["Message"] = "Added Successfully";
            return RedirectToAction("Index");
        }
        public ActionResult EditBook(int id)
        {
            BookDetails bookDetails = BookRepository.FindBook(id);
            return View(bookDetails);
        }
        [HttpPost]
        public ActionResult UpdateResult(BookDetails book)
        {
            BookRepository.UpdateBook(book.bookId, book.bookName, book.authorName);
            TempData["Message"] = "Updated Successfully";
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBook(int id)
        {
            BookRepository.DeleteBook(id);
            TempData["Message"] = "Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}