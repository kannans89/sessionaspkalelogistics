using DependencyInjectionApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionApp.Controllers
{
    public class HomeController : Controller
    {
        private IEmailService service;
        public HomeController(IEmailService service) { 
          this.service = service;
        }
        public async Task<IActionResult> Index()
        {
           // SendGridEmailServcie service = new SendGridEmailServcie();
             await service.SendEmail("admin@controller");
            return Content("<h1>Index action of home controller</h1>");
        }
    }
}
