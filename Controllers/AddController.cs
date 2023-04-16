using BookStore.Data;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class AddController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AddController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Book obj)
        {
            _db.Books.Add(obj);
            _db.SaveChanges();

            return RedirectToAction("Index","Home");
        }
        public IActionResult Edit(int ? id)
        {
            if(id == null || id <= 0)
            {
                return NotFound();
            }
            var book = _db.Books.Find(id);
            if(book == null)return NotFound();

            return View(book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book obj)
        {
            _db.Books.Update(obj);
            _db.SaveChanges();

            return RedirectToAction("Index","Home");
        }
        public IActionResult Details(int? id)
        {
            if (id == null || id <= 0)
            {
                return NotFound();
            }
            var book = _db.Books.Find(id);
            if (book == null) return NotFound();
           ViewBag.Book = book;
            return View();
        }
    }
}
