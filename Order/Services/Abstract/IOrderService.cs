using System.Collections.Generic;
using System.Threading.Tasks;
using Order.Models.Entities;

namespace Order.Services.Abstract
{
    public interface IOrderService
    {
        
        Task<Orders> GetOrderIdAsync(int id);
        Task<List<Orders>> GetOrderAsync();
        Task<Orders> SaveOrderAsync(Orders customer);
        Task UpdateOrdersAsync(Orders customer);
        Task DeleteOrderAsync(int id);
        Task OrderStatus(int id,string status);
    }
}