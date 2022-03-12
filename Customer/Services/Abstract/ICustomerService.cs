using System.Collections.Generic;
using System.Threading.Tasks;
using Customer.Models.Entities;

namespace Customer.Services
{
    public interface ICustomerService
    {
        Task<Customers> GetCustomerIdAsync(int id);
        Task<List<Customers>> GetCustomersAsync();
        Task<Customers> SaveCustomerAsync(Customers customer);
        Task UpdateCustomersAsync(Customers customer);
        Task DeleteCustomerAsync(int id);
        Task<bool> ValidateAsync(int id);

    }
}