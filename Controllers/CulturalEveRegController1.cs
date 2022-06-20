using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CulturalEventRegistrationApp.Controllers
{
    public class CulturalEveRegController1 : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
    }
}
