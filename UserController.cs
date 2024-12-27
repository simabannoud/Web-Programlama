using Microsoft.AspNetCore.Mvc;

namespace BeautySalonApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            // Oturumu sonlandır
            return RedirectToAction("Index", "Home");
        }
    }
}
