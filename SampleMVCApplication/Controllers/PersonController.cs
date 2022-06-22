using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using SampleMVCApplication.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace SampleMVCApplication.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult PersonalDetails()
        {
            List<string> Options = new List<string>();
            Options.Add("Choose an option");
            Options.Add("Yes");
            Options.Add("No");
            ViewData["Options"] = new SelectList(Options);
            return View();
        }
        [HttpPost]
        public ActionResult PersonalDetails(IFormCollection fc,ICollection<string> hobbies)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.hobbies = hobbies;
            ViewBag.options = fc["options"];
            return View("Details");  
        }


    }
}
