using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Order.Models.Entities;
using Order.Services.Abstract;

namespace Order.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController:ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IActionResult> GetOrders()
        {
            var order=await _orderService.GetOrderAsync();
            return Ok(order);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var order = await _orderService.GetOrderIdAsync(id);
            return Ok(order);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Orders model)
        {
            var order=await _orderService.SaveOrderAsync(model);
            return Ok(order);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id,Orders model)
        {
            
            if(id!=model.Id)
            return BadRequest("Not valid request");

            if(!ModelState.IsValid)
            return BadRequest(ModelState);

            await _orderService.UpdateOrdersAsync(model);

            return Ok(model);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderAsync(int id)
        {
           if(id==0)
            return BadRequest("Not valid request");

            if(!ModelState.IsValid)
            return BadRequest(ModelState);

            await _orderService.DeleteOrderAsync(id);
           
            return Ok();
        }

         [HttpGet("Validate/{id}")]
        public async Task<IActionResult> ChangeStatus(int id,string status)
        {
            
            await _orderService.OrderStatus(id,status);

            return Ok();
        }
    }
}