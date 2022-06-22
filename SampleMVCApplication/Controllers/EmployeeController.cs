using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using SampleMVCApplication.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace SampleMVCApplication.Controllers
{
    public class EmployeeController : Controller
    {


        /*public IActionResult ListEmp()
        {
            List<Employee> Employeelist = new List<Employee>()
              {
                  new Employee{Id=1,Name="Tushar",Company="Infosys",Salary=49999},
                  new Employee{Id=1,Name="Tushar",Company="Infosys",Salary=49999},
                  new Employee{Id=1,Name="Tushar",Company="Infosys",Salary=49999},
                  new Employee{Id=1,Name="Tushar",Company="Infosys",Salary=49999}

              };
            ViewBag.Employeelist = Employeelist;
            return View();
        }*/
        [HttpGet]
        public IActionResult EmployeeDetails()
        {
            List<string> Options = new List<string>();
            Options.Add("Choose an option");
            Options.Add("Yes");
            Options.Add("No");
            ViewData["Options"] = new SelectList(Options);
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeDetails(IFormCollection fc)
        {
            ViewBag.employeename = fc["employeename"];
            ViewBag.employeeid = fc["employeeid"];
            ViewBag.department = fc["department"];
            ViewBag.designation = fc["designation"];
            ViewBag.salary = fc["salary"];
            return View("Details");
        }
    }
}
