using Microsoft.AspNetCore.Mvc;

namespace SampleMVCApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ProductList()
        {
            ViewData["Message"] = "This is my first mvc app";
            return View();
        }
    }
}
