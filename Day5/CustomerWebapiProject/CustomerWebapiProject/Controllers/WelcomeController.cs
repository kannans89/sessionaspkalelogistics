using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWebapiProject.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {

        [HttpGet("greeting/display")]
        public string GetGreeting() {

            return "hello";
        }

        [HttpPost("greeting/add")]
        public string PostGreeting() {
            return "hello post";
        }

        [HttpPut("greeting/edit")]
        public string PutGreeting()
        {
            return "hello put";
        }


        [HttpDelete("greeting/delete")]
        public string DeleteGreeing() {
            return "hello delete";
        }
    }
}
