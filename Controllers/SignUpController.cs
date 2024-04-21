using Microsoft.AspNetCore.Mvc;
using DisProject.Models;
using DisProject.Global_Variables;

using System.Collections.Generic;

namespace DisProject.Controllers
{
    using DisProject.Global_Variables;

    // SignUpController.cs
    using Microsoft.AspNetCore.Mvc;

    public class SignUpController : Controller
    {
        // Action to display the sign-up form
        public IActionResult Index()
        {
            return View();
        }

        // Action to handle sign-up form submission
        [HttpPost]
        public IActionResult Create(SignUpModel model) // Here, SignUpModel model receives form data
        {
            if (ModelState.IsValid)
            {
                // Generate a unique ID for the user
                int userId = GlobalData.Users.Count + 1;
                model.Id = userId;

                // Add the user to the global data
                GlobalData.Users.Add(userId, model);

                // Redirect to home page or show success message
                return RedirectToAction("Index", "Success");
            }
            return View(model);
        }
    }


}
