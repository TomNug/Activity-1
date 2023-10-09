using Microsoft.AspNetCore.Mvc;
using Activity_1.Services;

namespace Activity_1.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessLogin(Models.UserModel userModel)
        {
            SecurityService securityService = new SecurityService();
            if (securityService.isValid(userModel))
            {
                return View("LoginSuccess", userModel);
            } else
            {
                return View("LoginFailure", userModel);
            }
        }
    }
}
