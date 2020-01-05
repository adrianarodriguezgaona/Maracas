using Maracas.Lib.Models;
using MaracasMusic.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaracasMusic.API.Repositories
{
    public class OrderDetailRepository : RepositoryBase<OrderDetails>
    {

        public OrderDetailRepository(MaracasContext maracasContext) : base(maracasContext)
        {

        }

        public async Task<List<OrderDetails>> GetOrderDetailByorderId(int orderId)
        {
            return await _maracasContext.OrderDetails
              .Where(od => od.OrderId == orderId)
              .ToListAsync();

        }
    }
}
