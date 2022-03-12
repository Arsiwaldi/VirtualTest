using Microsoft.AspNetCore.Mvc;

namespace VirtualRootTest.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string GetInfo() => "I am returned info from server"; 
    }
}
