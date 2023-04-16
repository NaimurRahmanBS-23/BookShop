using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class AddBookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
