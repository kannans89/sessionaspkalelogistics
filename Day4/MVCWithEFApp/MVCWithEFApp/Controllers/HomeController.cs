using Microsoft.AspNetCore.Mvc;
using MVCWithEFApp.Data;
using MVCWithEFApp.Domain;
using MVCWithEFApp.Models;
using System.Diagnostics;

namespace MVCWithEFApp.Controllers
{
    public class HomeController : Controller
    {
       
        private OrganizationDbContext _organizationDbContext;

        public HomeController(OrganizationDbContext orgContext)
        {
           _organizationDbContext = orgContext;
        }

        public IActionResult Index()
        {
            ViewBag.Count = _organizationDbContext.Organizations.Count();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
