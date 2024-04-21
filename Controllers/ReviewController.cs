using DisProject.Global_Variables;
using DisProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DisProject.Models;


namespace DisProject.Controllers
{
    public class ReviewController : Controller
    {
        // Action to display the review page
        public IActionResult Index()
        {
            List<ReviewModel> reviews = new List<ReviewModel>(GlobalData.Reviews.Values);
            return View(reviews);
        }

        // Action to handle review submission
        [HttpPost]
        public IActionResult Create(ReviewModel model)
        {
            if (ModelState.IsValid)
            {
                // Generate a unique ID for the review
                int reviewId = GlobalData.Reviews.Count + 1;
                model.Id = reviewId;

                // Add the review to the global data
                GlobalData.Reviews.Add(reviewId, model);

                // Redirect to the review page
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // Action to display review details
        public IActionResult Details(int id)
        {
            if (GlobalData.Reviews.ContainsKey(id))
            {
                var review = GlobalData.Reviews[id];
                return View(review);
            }
            return NotFound();
        }

        // Action to display review edit form
        public IActionResult Edit(int id)
        {
            if (GlobalData.Reviews.ContainsKey(id))
            {
                var review = GlobalData.Reviews[id];
                return View(review);
            }
            return NotFound();
        }

        // Action to handle review update
        [HttpPost]
        public IActionResult Edit(ReviewModel model)
        {
            if (ModelState.IsValid)
            {
                if (GlobalData.Reviews.ContainsKey(model.Id))
                {
                    // Update the review in the global data
                    GlobalData.Reviews[model.Id] = model;

                    // Redirect to the review page
                    return RedirectToAction("Index");
                }
                return NotFound();
            }
            return View(model);
        }

        // Action to display confirmation page for review deletion
        public IActionResult Delete(int id)
        {
            if (GlobalData.Reviews.ContainsKey(id))
            {
                var review = GlobalData.Reviews[id];
                return View(review);
            }
            return NotFound();
        }

        // Action to handle review deletion
        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            if (GlobalData.Reviews.ContainsKey(id))
            {
                // Remove the review from the global data
                GlobalData.Reviews.Remove(id);

                // Redirect to the review page
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
