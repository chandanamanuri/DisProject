using DisProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace DisProject.Controllers
{
    public class ReviewController : Controller
    {
        private static Dictionary<int, ReviewModel> reviews = new Dictionary<int, ReviewModel>();
        private static int reviewId = 0;

        // GET: Home/Index
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddReview(ReviewModel model)
        {
            reviewId++;
            model.Id = reviewId;
            reviews.Add(reviewId, model);
            return RedirectToAction("Index", "Success");
        }
    }
}


