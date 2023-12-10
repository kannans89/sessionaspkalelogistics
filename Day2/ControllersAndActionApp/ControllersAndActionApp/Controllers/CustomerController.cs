using ControllersAndActionApp.Filters;
using ControllersAndActionApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActionApp.Controllers
{

    
    public class CustomerController : Controller
    {

        [LogThisAction]
        public IActionResult Index(int id)
        {
            return Content("Display id "+id);
        }

       
        public IActionResult IndexV2() {
            ViewBag.Data = 10;
            return View("Index");
        }



        [LogThisAction]
        public IActionResult Detail() {

            Console.WriteLine("inside details");
            var c = new Customer {
             Id = 1,
              Name = "KaleLogistics",
            };

            return View(c);
        }
    }
}
