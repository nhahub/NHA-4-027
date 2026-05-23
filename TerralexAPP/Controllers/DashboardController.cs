using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TerralexAPP.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Clients()
        {
            ViewData["Title"] = "Clients";
            return View();
        }

        public IActionResult Properties()
        {
            ViewData["Title"] = "Properties";
            return View();
        }

        public IActionResult Documents()
        {
            ViewData["Title"] = "Documents";
            return View();
        }
    }
}
