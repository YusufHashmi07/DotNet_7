
using FeedbackManagementApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackManagementApp.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Feedback());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Feedback feedback)
        {
            if (!ModelState.IsValid)
            {
                return View(feedback);
            }

            TempData["FeedbackName"] = feedback.Name;
            TempData["FeedbackMessage"] =
                "Your feedback has been submitted successfully.";

            return RedirectToAction(nameof(Success));
        }

        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }
    }
}
