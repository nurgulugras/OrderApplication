using System.Collections.Generic;
using System.Threading.Tasks;
using Order.Data;
using Order.Models.Entities;
using Order.Services.Abstract;

namespace Order.Services.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Orders> _orderRepository;

        public OrderService(IRepository<Orders> orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task DeleteOrderAsync(int id)
        {
            var dbOrder= await _orderRepository.GetEntityByIdAsync(id);
            await _orderRepository.DeleteAsync(dbOrder);
        }

        public Task<List<Orders>> GetOrderAsync()
        {
            return _orderRepository.GetsAsync();
        }

        public async Task<Orders> GetOrderIdAsync(int id)
        {
            var order= await _orderRepository.GetEntityByIdAsync(id);
            return order;
        }

        public async Task OrderStatus(int id,string status)
        {
            var dbOrder= await _orderRepository.GetEntityByIdAsync(id);
           dbOrder.Status=status;
           await _orderRepository.UpdateAsync(dbOrder);
        }

        public Task<Orders> SaveOrderAsync(Orders order)
        {
            return _orderRepository.SaveAsync(order);
        }

        public Task UpdateOrdersAsync(Orders order)
        {
            return _orderRepository.UpdateAsync(order);
        }
    }
}