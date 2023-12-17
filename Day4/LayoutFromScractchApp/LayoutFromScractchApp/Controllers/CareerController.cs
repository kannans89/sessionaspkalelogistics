using Microsoft.AspNetCore.Mvc;

namespace LayoutFromScractchApp.Controllers
{
	public class CareerController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
