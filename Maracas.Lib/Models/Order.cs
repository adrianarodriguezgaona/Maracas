using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Order : EntityBase
    {
        public int ClientId { get; set; }
        public string Address { get; set; }
        public Client Client { get; set; }
        public DateTime DateOrder { get; set; }
        public List <OrderDetails> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetails>();
        }

    }
}
