using Microsoft.AspNetCore.Mvc;

namespace AceNutTrackerWebApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
