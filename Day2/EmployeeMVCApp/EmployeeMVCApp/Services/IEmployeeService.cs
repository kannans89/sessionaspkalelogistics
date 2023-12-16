using EmployeeMVCApp.Model;

namespace EmployeeMVCApp.Services
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
        IEnumerable<Employee> GetAll();

        int HeadCount();
    }
}
