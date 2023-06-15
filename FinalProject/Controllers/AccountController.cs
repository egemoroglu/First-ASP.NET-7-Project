using FinalProject.Sessions;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var account = _accountService.Login(username, password);
            if (account != null)
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Welcome", account);
            }

            ViewBag.Massage = "Naptın";
            return View();
        }
        public IActionResult Welcome()
        {
            ViewBag.Massage = "Giriş Başarılı";
            ViewBag.Massage2 = HttpContext.Session.GetString("username");
            return View();
        }
        public IActionResult Logout()
        {

            HttpContext.Session.Remove("username");
            return RedirectToAction("Index", "Account");
        }
    }
}
