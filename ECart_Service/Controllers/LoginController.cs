using Microsoft.AspNetCore.Mvc;

namespace ECart_Service.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
