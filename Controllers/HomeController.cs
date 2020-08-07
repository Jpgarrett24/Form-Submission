using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            return View("Success");
        }

        [HttpPost("")]
        public IActionResult Submit(User newUser)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            else
            {
                return View("Index");
            }
        }
    }
}