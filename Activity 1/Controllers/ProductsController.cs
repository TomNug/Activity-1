using Microsoft.AspNetCore.Mvc;

namespace Activity_1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // This action is run when /products/message is visited
        public IActionResult Message()
        {
            return View();
        }

        public IActionResult Welcome(string name, int secretNumber=123)
        {
            ViewBag.Name = name;
            ViewBag.SecretNumber = secretNumber;
            return View();
        }
    }
}
