using Microsoft.AspNetCore.Mvc;

namespace DisProject.Controllers
{
    public class BookInsightsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
