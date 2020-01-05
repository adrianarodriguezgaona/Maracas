using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
     public class OrderDetails : EntityBase
    {
       
       public int OrderId { get; set; }
        [JsonIgnore]
        public Order Order { get; set; }
        public int ProductId { get; set; }
        [JsonIgnore]
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}
