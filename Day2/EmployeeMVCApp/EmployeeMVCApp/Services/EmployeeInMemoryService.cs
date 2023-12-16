using EmployeeMVCApp.Model;

namespace EmployeeMVCApp.Services
{
    public class EmployeeInMemoryService : IEmployeeService
    {
        private List<Employee> _employees;

        public EmployeeInMemoryService()
        {

            _employees = new List<Employee>() {
          new Employee{ Id=1,Name="Emp1",IsActive=true },
           new Employee{ Id=2,Name="Emp2",IsActive=true }

         };

        }
        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public int HeadCount()
        {
            return _employees.Count();
        }
    }
}
