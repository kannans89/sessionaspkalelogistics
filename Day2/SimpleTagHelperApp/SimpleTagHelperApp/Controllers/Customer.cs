using Microsoft.AspNetCore.Mvc;

namespace SimpleTagHelperApp.Controllers
{
    public class Customer : Controller
    {
        public IActionResult Index() { 
          return View();
        }
        public IActionResult About()
        {
            return Content("About of customer");
        }
    }
}
