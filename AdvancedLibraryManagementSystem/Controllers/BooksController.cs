using Microsoft.AspNetCore.Mvc;

namespace AdvancedLibraryManagementSystem.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}