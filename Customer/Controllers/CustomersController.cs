

using System.Threading.Tasks;
using Customer.Models.Entities;
using Customer.Services;
using Microsoft.AspNetCore.Mvc;

namespace Customer.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController:ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IActionResult> GetCustomers()
        {
            var customer=await _customerService.GetCustomersAsync();
            return Ok(customer);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            var customer = await _customerService.GetCustomerIdAsync(id);
            return Ok(customer);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Customers model)
        {
            var customer=await _customerService.SaveCustomerAsync(model);
            return Ok(customer);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id,Customers model)
        {
            
            if(id!=model.Id)
            return BadRequest("Not valid request");

            if(!ModelState.IsValid)
            return BadRequest(ModelState);

            await _customerService.UpdateCustomersAsync(model);

            return Ok(model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomerAsync(int id)
        {
           if(id==0)
            return BadRequest("Not valid request");

            if(!ModelState.IsValid)
            return BadRequest(ModelState);

            await _customerService.DeleteCustomerAsync(id);
           
            return Ok();
        }

         [HttpGet("Validate/{id}")]
        public async Task<IActionResult> ValidateAsync(int id)
        {
            var result = await _customerService.ValidateAsync(id);

            return Ok(result);
        }
    }
}