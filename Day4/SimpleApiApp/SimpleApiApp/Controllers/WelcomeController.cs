using Microsoft.AspNetCore.Mvc;

namespace SimpleApiApp.Controllers
{
	[ApiController]
	[Route("api/v1/[controller]")]
	public class WelcomeController:ControllerBase
	{

		[HttpGet]
		public string Get() {
			return "Get called";
		}

		[HttpPost]
		public string Post() {
			return "Post called";
		}

		[HttpPut("myput/edit")]
		public string Put()
		{
			return "Put called";
		}

		[HttpDelete]
		public string Delete()
		{
			return "Delete called";
		}

	}
}
