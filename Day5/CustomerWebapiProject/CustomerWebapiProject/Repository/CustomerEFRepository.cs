using CustomerWebapiProject.Data;
using CustomerWebapiProject.Domain;

namespace CustomerWebapiProject.Repository
{
    public class CustomerEFRepository : ICustomerRepository
    {
        private readonly CustomerDbContext _db;
        public CustomerEFRepository(CustomerDbContext db) {
            _db = db;
        }
        public void AddCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
        }

        public Customer GetCustomerById(int id)
        {
          return _db.Customers.FirstOrDefault(c=>c.Id==id);
        }

        public List<Customer> GetCustomers()
        {
           return  _db.Customers.ToList();
        }
    }
}
