using Microsoft.AspNetCore.Mvc;

namespace Activity_1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
