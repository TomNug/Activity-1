using Microsoft.AspNetCore.Mvc;

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
            if (userModel.Username == "user" && userModel.Password == "pass")
            {
                return View("LoginSuccess", userModel);
            } else
            {
                return View("LoginFailure", userModel);
            }
        }
    }
}
