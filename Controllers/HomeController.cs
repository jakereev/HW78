using Microsoft.AspNetCore.Mvc;

namespace HW78.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
