using AutoMapper;
using BlackLotus.Data;
using BlackLotus.DTO;
using BlackLotus.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlackLotus.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class OrderController : Controller
    {

        private readonly IOrderRepo orderRepo;
        private readonly IMapper mapper;

        public OrderController(IOrderRepo _orderRepo, IMapper _mapper)
        {
            orderRepo = _orderRepo;
            mapper = _mapper;
        }
        [HttpGet]
        public ActionResult<IEnumerable<OrderReadDTO>> GetOrders()
        {
            var orders = orderRepo.GetOrders();
            return Ok(mapper.Map<IEnumerable<OrderReadDTO>>(orders));
        }
        [HttpGet("{orderId}", Name ="getOrderById")]
        public ActionResult<OrderReadDTO> getOrderById(int orderId)
        {
            var order = orderRepo.GetOrderById(orderId);
            if(order != null)
                return Ok(mapper.Map<OrderReadDTO>(order));
            else
                return NotFound();
        }
 
        [HttpPost]
        public ActionResult<OrderCreateDTO> createOrder(OrderCreateDTO order)
        {
            var orderModel = mapper.Map<Order>(order);
            orderRepo.createOrder(orderModel);
            orderRepo.Save();

    
            var newOrder = mapper.Map<OrderReadDTO>(orderModel);
            return CreatedAtRoute(nameof(getOrderById), new {orderId = newOrder.orderId}, newOrder);
        }
      
        [HttpDelete("{orderId}")]
        public ActionResult delete(int orderId)
        {
            var orderToDelete = orderRepo.GetOrderById(orderId);
            if (orderToDelete == null)
                return NotFound();
            orderRepo.deleteOrder(orderToDelete);
            return Ok();
        }
    
        [HttpPut]
        public ActionResult update (int orderId, OrderCreateDTO order)
        {
            var ordertToUpdate = mapper.Map<Order>(order);
            ordertToUpdate.orderId = orderId;
            if (!orderRepo.updateOrder(ordertToUpdate))
                return NotFound();
            else
                return Ok();
        }


    }
}
