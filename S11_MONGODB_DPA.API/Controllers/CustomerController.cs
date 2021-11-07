using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S11_MONGODB_DPA.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S11_MONGODB_DPA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerController(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        [HttpGet]
        [Route("GetCustomers")]
        public async Task<IActionResult> GetCustomers()
        {
            var result = await _customerRepository.GetCustomers();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetCustomerById")]
        public async Task<IActionResult> GetCustomerById(string id)
        {
            var result = await _customerRepository.GetCustomerById(id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }




    }
}
