using FinalProject.Sessions;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class AdminController : Controller
    {
        private IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string username, string password)
        {
            var admin = _adminService.Login(username, password);
            if (admin != null)
            {
                HttpContext.Session.SetString("username", username);
                return RedirectToAction("Welcome", admin);
            }

            //ViewBag.Massage = "Naptın";
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
            return RedirectToAction("Index", "Admin");
        }
    }
}
