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
            IEnumerable<Book> bookList=_db.Books.ToList();
            return View(bookList);
        }
    }
}