using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageFormApp.Pages
{

    //[IgnoreAntiforgeryToken]
    public class GreetingModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; } = "Akash";
        public string Message { get; set; } = "";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            Message += $"Welcome back user {UserName}";
        }

    }
}
