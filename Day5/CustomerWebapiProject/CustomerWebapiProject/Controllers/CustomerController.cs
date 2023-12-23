using CustomerWebapiProject.Domain;
using CustomerWebapiProject.DTOs;
using CustomerWebapiProject.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerWebapiProject.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerRepository _repository;
        public CustomerController(ICustomerRepository repostiory) { 
        
          _repository = repostiory;
        }

        [HttpGet("allcustomers")]
        public IActionResult GetAllCustomers() {

            List<CustomerDto> dtos = new List<CustomerDto>();
            foreach(var c in _repository.GetCustomers())
            {
                dtos.Add(new CustomerDto { Id=c.Id,FullName=c.FirstName+ ","+c.LastName });
            }

            if (dtos.Count == 0)
                return StatusCode(404);

            return Ok(dtos);
          
        
        }

        [HttpGet("allcustomers/{customerId}")]
        public IActionResult GetCustomersById(int customerId) {

           var customer = _repository.GetCustomerById(customerId);

            return Ok(new CustomerDto { Id=customer.Id,FullName=customer.FirstName+","+customer.LastName });
        }

        [HttpPost("AddCustomer")]
        public IActionResult AddCustomer(CustomerDto dto)
        {
            var name = dto.FullName.Split(",");
            Customer c = new Customer();
            c.Id = dto.Id;
            c.FirstName = name[0];
            c.LastName = name[1];

            _repository.AddCustomer(c);

            return Ok();
        }



    }
}
