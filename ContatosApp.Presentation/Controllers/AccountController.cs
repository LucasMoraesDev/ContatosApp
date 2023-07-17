using Microsoft.AspNetCore.Mvc;

namespace ContatosApp.Presentation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult PasswordRecover()
        {
            return View();
        }
    }
}
