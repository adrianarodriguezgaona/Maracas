using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
   public class Product
    {
        public long Id { get; set; }
        public long ProductTypeId { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }

        public long OrderId { get; set; }
        public Order Order { get; set; }

    }
}
