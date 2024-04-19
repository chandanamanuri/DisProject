using Microsoft.AspNetCore.Mvc;

namespace DisProject.Controllers
{
    public class FeaturedBooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
