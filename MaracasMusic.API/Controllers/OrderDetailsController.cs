using Maracas.Lib.Models;
using MaracasMusic.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerCrudBase<OrderDetails, OrderDetailRepository>
    {
        public OrderDetailsController(OrderDetailRepository orderDetailRepository) : base(orderDetailRepository)
        {

        }

        [HttpGet]
        [Route("GetByOrderId/{OrderId}")]


        public virtual async Task<IActionResult> GetByOrderId(int orderId)

        {
            return Ok(await repository.GetOrderDetailByorderId(orderId));
        }
    }
}
