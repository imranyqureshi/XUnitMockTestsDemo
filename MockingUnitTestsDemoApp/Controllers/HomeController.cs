using Microsoft.AspNetCore.Mvc;

namespace MockingUnitTestsDemoApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
    }
}