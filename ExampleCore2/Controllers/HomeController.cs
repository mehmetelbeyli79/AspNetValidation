using Microsoft.AspNetCore.Mvc;
using ExampleCore2.Models;
namespace ExampleCore2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Index(Product product)
        {
            ViewBag.id = product.id;
            ViewBag.name = product.name;
            ViewBag.description = product.description;
            ViewBag.category = product.category;
            return View();
        }
    }
}
