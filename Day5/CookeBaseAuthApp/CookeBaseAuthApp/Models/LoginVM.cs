using System.ComponentModel.DataAnnotations;

namespace CookeBaseAuthApp.Models
{
    public class LoginVM
    {

        [Required(ErrorMessage = "UserId must be entered by user")]
        [DataType(DataType.Text)]
        public string UserId { get; set; }

        [Required(ErrorMessage = "UserPassword must be entered by user")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
    }
}
