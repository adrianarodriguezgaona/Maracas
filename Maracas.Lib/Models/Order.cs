using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Order : EntityBase
    {
        public int ClientId { get; set; }
        [JsonIgnore]
        public Client Client { get; set; }
        public DateTime DateOrder { get; set; }
        public List <OrderDetails> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetails>();
        }

    }
}
