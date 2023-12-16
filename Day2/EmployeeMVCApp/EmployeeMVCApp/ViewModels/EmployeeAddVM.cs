using System.ComponentModel.DataAnnotations;

namespace EmployeeMVCApp.ViewModels
{
    public class EmployeeAddVM
    {

        [Required(ErrorMessage ="Id is mandaotry")]
        [Display(Name ="Employee Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is mandaotry")]
        [Display(Name = "Employee Name")]
        public string Name { get; set; } = "";

        public bool IsActive {  get; set; }

        public string AddTitle { get; set; } = "";
        public string AddHeading { get; set; } = "";
    }
}
