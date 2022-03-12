using System.Collections.Generic;
using System.Threading.Tasks;
using Customer.Data;
using Customer.Models.Entities;

namespace Customer.Services.Concrete
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Customers> _customerRepository;

        public CustomerService(IRepository<Customers> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task DeleteCustomerAsync(int id)
        {
            var dbCustomer= await _customerRepository.GetEntityByIdAsync(id);
            await _customerRepository.DeleteAsync(dbCustomer);
        }

        public async Task<Customers> GetCustomerIdAsync(int id)
        {
            var customer= await _customerRepository.GetEntityByIdAsync(id);
            return customer;
        }

        public Task<List<Customers>> GetCustomersAsync()
        {
            return _customerRepository.GetsAsync();
        }

        public Task<Customers> SaveCustomerAsync(Customers customer)
        {
            return _customerRepository.SaveAsync(customer);
        }

        public Task UpdateCustomersAsync(Customers customer)
        {
            return _customerRepository.UpdateAsync(customer);
        }

        public async Task<bool> ValidateAsync(int id)
        {
          var result= await _customerRepository.GetEntityByIdAsync(id);
          if(result==null)
          {
             return false;
          }
             return true;

        }
    }
}