﻿using Microsoft.AspNetCore.Mvc;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
