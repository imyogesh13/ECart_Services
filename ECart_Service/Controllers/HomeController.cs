using Microsoft.AspNetCore.Mvc;

namespace ECart_Service.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
