using CrossSiteScriptonApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CrossSiteScriptonApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SendComment()
        {

            return View();
        }

        [HttpPost]
        public IActionResult SendComment(string comment)
        {

            ViewBag.Comment = comment;
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
