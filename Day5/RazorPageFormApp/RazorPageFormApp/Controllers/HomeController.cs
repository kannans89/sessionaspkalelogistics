using Microsoft.AspNetCore.Mvc;

namespace RazorPageFormApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("<h1>Inside index of mvc contorller</h1>","text/html");
        }
    }
}
