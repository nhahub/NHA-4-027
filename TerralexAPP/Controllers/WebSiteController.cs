using Microsoft.AspNetCore.Mvc;

namespace TerralexAPP.Controllers
{
    public class WebSiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
