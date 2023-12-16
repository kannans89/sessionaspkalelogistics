using EmployeeMVCApp.Model;

namespace EmployeeMVCApp.ViewModels
{
    public class EmployeeIndexVM
    {
        public string IndexTitle { get; set; } = "";
        public string IndexHeading { get; set; } = "";

        public List<Employee> Employees { get; set; }= new List<Employee>();

        public int Employeecount { get; set; }

        public string GetStatus(bool active) {
            return active == true ? " Active" : "InActive";
        }
    }
}
