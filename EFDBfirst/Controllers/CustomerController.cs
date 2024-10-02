using EFDBfirst.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFDBfirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        [HttpGet]

        public async Task<ActionResult> GetEmployees()
        {
            try
            {
                var data = await customerRepository.GetCustomers();

                return Ok(data);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                 "Error retrieving data from the database");
            }
        }


        [HttpGet("CustomerId")]
        public async Task<ActionResult> GetCustomerById(string CustomerId)
        {
            try
            {
                var result = await customerRepository.GetById(CustomerId);

                return result != null? Ok(result) : NotFound();

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
