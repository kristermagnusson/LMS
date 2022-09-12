﻿using LMS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (User.IsInRole("Student"))
                return View(); 
                //return RedirectToPage("/Home/IndexStudent.cshtml");
            return RedirectToAction(nameof(IndexTeacher));
        }


        public IActionResult IndexTeacher()
        {

            return View();

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}