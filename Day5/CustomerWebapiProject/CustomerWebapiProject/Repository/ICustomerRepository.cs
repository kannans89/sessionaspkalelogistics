using CustomerWebapiProject.Domain;

namespace CustomerWebapiProject.Repository
{
    public interface ICustomerRepository
    {

       List<Customer> GetCustomers();

        Customer GetCustomerById(int id);
       void AddCustomer(Customer customer);
    }
}
