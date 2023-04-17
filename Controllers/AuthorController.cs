using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class AuthorController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AuthorController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int ? id)
        {
           var name=_db.Books.FirstOrDefault()?.AuthorName;
            var bookList= _db.Books.Where(x => x.AuthorName == name).ToList();
         
            return View(bookList);
        }
    }
}
