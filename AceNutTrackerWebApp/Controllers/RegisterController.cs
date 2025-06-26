using Microsoft.AspNetCore.Mvc;

namespace AceNutTrackerWebApp.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
