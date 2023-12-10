using Microsoft.AspNetCore.Mvc;
using SimpleTagHelperApp.Model;

namespace SimpleTagHelperApp.Controllers
{
    public class DeveloperController : Controller
    {
        public IActionResult Index() { 

            Developer developer = new Developer();
            developer.FirstName = "Dev FirstName";
            developer .LastName = "Dev Lastname";

          return View(developer);
        }
        public IActionResult About()
        {
            return Content("About of customer");
        }
    }
}
