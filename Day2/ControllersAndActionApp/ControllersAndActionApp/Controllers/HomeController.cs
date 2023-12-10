using ControllersAndActionApp.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActionApp.Controllers
{

    [LogThisAction]
    public class HomeController : Controller
    {

        public ContentResult Index()
        {
           

            return Content("test index");
        }

        public FileResult ShowLogo()
        {
            return File("/logo.jpg", "image/jpeg");
        }

        public IActionResult GetRandom()
        {
            var random = new Random();
            var result = random.Next(1, 10);
            if (result >= 5)
                return ShowLogo();

            return Index();
        }

        public IActionResult RedirectV1() {
            return Redirect("http://www.google.com");
        }

        public IActionResult RedirectV2() {
            return RedirectToAction("ShowLogo");
        }

        public IActionResult RedirectV3()
        {
            return RedirectToAction("Index","customer");
        }

        [Route("/myImage",Name ="myImageRoute")]
        public IActionResult GetImage() {
            return ShowLogo();
        }

        public IActionResult RedirectV4()
        {
            return RedirectToRoute("myImageRoute");

        }

    }
}
