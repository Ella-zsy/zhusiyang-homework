using Microsoft.AspNetCore.Mvc;
using Assignment9.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Assignment9.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController: ControllerBase
    {
        private readonly OrderService orderService;

        public OrderController(OrderService orderService)
        {
            this.orderService = orderService;
        }
        // GET: api/Order
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            return orderService.GetAllOrders();
        }

        // GET: api/Order/1
        [HttpGet("{id}")]

        //对订单的查找
        public ActionResult<Order> GetOrder(string id)
        {
            var order = orderService.GetOrder(id);
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        // POST: api/Order
        [HttpPost]

        //对订单的添加
        public ActionResult<Order> AddOrder(Order order)
        {
            try
            {
                order.OrderId = Guid.NewGuid().ToString();
                orderService.AddOrder(order);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

            return order;
        }

        // PUT: api/Order/1
        [HttpPut("{id}")]

        //对订单的更改
        public ActionResult<Order> updateOrder(string id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest();
            }
            try
            {
                orderService.UpdateOrder(order);
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/Order/1
        [HttpDelete("{id}")]

        //对订单的删除
        public ActionResult<Order> DeleteOrder(string id)
        {
            try
            {
                orderService.RemoveOrder(id);
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}
