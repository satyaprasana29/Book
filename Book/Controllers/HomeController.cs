using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
        public ActionResult DataPassing()
        {
            IEnumerable<BookDetails> bookDetails = BookRepository.GetBooks();
            ViewBag.Books = bookDetails;
            return View(bookDetails);
        }
        public ActionResult Viewdata()
        {
            IEnumerable<BookDetails> bookDetails = BookRepository.GetBooks();
            ViewData["book"] = bookDetails;
            return View();
        }
        public ActionResult TempDataCall()
        {
            IEnumerable<BookDetails> bookDetails = BookRepository.GetBooks();
            TempData["books"] = bookDetails;
            return RedirectToAction("TempDataResult");
        }
        public ActionResult TempDataResult()
        {
            return View();
        }
    }
}