using Microsoft.AspNetCore.Mvc;

namespace DisProject.Controllers
{
    public class MembershipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
