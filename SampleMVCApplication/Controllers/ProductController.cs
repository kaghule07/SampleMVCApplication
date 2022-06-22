using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using SampleMVCApplication.Models;
namespace SampleMVCApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetAllProduts()
        {
            List<Product> productlist = new List<Product>()
            {
                new Product{Id=1,Name="Laptop",Company="Dell",Price=49999},
                new Product{Id=2,Name="Laptop",Company="Dell",Price=49999},
                new Product{Id=3,Name="Laptop",Company="Dell",Price=49999},
                new Product{Id=4,Name="Laptop",Company="Dell",Price=49999},
                new Product{Id=5,Name="Laptop",Company="Dell",Price=49999},

            };
            ViewBag.ProductList = productlist;  
            foreach(Product product in productlist)
            {

            }
            return View();   
        }
    }
}
