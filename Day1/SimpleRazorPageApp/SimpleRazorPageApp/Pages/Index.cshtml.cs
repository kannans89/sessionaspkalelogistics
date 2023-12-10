using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleRazorPageApp.Pages
{
    class Employee { 
    
    }
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private Employee _emp;//default value is null
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}
