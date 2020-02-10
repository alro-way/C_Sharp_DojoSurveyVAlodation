using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using C_Sharp_DojoSurveyVAlodation.Models;

namespace C_Sharp_DojoSurveyVAlodation.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public IActionResult Form()
        {
            return View("Form");
        }

        [HttpPost("create")]
        public IActionResult Create(User newUser)
        {
            
            if(ModelState.IsValid)
            {
                Console.WriteLine(newUser.Location);
                Console.WriteLine(newUser.Name);
                Console.WriteLine("**********************");
    // RENDERING page with result, How to redirect???
                return View("Survey", newUser);
            }
            else
            {
                return View("Form");
            }
        }

        [HttpPost("survey")]
        public IActionResult Survey(User newUser)
        {
            return View("Survey");
        }


        // public IActionResult Index()
        // {
        //     return View();
        // }

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
