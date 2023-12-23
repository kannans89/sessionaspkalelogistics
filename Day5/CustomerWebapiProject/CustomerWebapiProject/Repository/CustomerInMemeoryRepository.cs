using CustomerWebapiProject.Domain;

namespace CustomerWebapiProject.Repository
{
    public class CustomerInMemeoryRepository : ICustomerRepository
    {
        private readonly List<Customer> _customers = default;

        public CustomerInMemeoryRepository() {

            _customers = new List<Customer>();
            _customers.Add(new Customer {  Id=1,FirstName="kannan",LastName="s"});
            _customers.Add(new Customer { Id = 2, FirstName = "Omendra", LastName = "Yadav" });
        }
        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public Customer GetCustomerById(int id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }

        public List<Customer> GetCustomers()
        {
            return _customers;
        }
    }
}
