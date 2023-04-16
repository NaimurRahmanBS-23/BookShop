using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
 
        public IActionResult Index()
        {
            IEnumerable<Book> bookList=_db.Books;
            return View(bookList);
        }
        public IActionResult Add()
        {
            
            return View();
        }
        //post method
        [HttpPost]
        [IgnoreAntiforgeryToken]
        public IActionResult Index(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}