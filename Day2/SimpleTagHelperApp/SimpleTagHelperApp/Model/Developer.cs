using System.ComponentModel.DataAnnotations;

namespace SimpleTagHelperApp.Model
{
    public class Developer
    {
        [Display(Name ="First-Name")]
        public string FirstName { get; set; } = "";
        [Display(Name = "Last-Name")]
        public string LastName { get; set; } = "";
    }
}
