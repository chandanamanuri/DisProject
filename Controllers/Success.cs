using Microsoft.AspNetCore.Mvc;

namespace DisProject.Controllers
{
    public class Success : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
