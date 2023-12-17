using ExceptionsAndLoggingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExceptionsAndLoggingApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
			_logger.LogInformation("inside home controller".ToUpper());
			Console.WriteLine(logger.GetType().ToString().ToUpper()) ;
        }

		public IActionResult Index()
		{
			_logger.LogCritical("inside home controller".ToUpper());
			_logger.LogError("inside home controller".ToUpper());
			return View();
		}

		public IActionResult Privacy()
		{
			_logger.LogWarning("inside home controller".ToUpper());

			throw new Exception("Invalid operation");
			//return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
