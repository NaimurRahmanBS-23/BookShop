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
            if(id == null|| id==0)
            {
                return NotFound();
            }
           var name=_db.Books.Find(id).AuthorName;
            var bookList= _db.Books.Where(x => x.AuthorName == name).ToList();
         
            return View(bookList);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var name = _db.Books.Find(id);
            
        
            return View(name);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            var name = _db.Books.Find(obj.Id).AuthorName;
            var books=_db.Books.Where(x=>x.AuthorName == name).ToList();
            foreach (var book in books)
            {
                book.AuthorName=obj.AuthorName;
                //_db.Books.Update(book);
               
            }
            _db.Books.UpdateRange(books);
            _db.SaveChanges();
            return RedirectToAction("Index","Home");
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var name = _db.Books.Find(id);


            return View(name);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Book obj)
        {
            if (obj == null)
            {
                return NotFound();
            }
            var name = _db.Books.Find(obj.Id).AuthorName;
            var books = _db.Books.Where(x => x.AuthorName == name).ToList();
            foreach (var book in books)
            {
                book.AuthorName = obj.AuthorName;
                //_db.Books.Update(book);

            }
            _db.Books.RemoveRange(books);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
