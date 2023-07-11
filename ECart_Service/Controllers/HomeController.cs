using Microsoft.AspNetCore.Mvc;

namespace ECart_Service.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //changes added in git
            return View();
        }
    }
}
