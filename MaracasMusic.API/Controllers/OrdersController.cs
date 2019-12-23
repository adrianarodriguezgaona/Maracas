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
    public class OrdersController : ControllerCrudBase<Order, OrderRepository>
    {
        public OrdersController(OrderRepository orderRepository) : base(orderRepository)
        {

        }
        
    }
}
