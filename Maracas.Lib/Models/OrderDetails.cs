using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
     public class OrderDetails : EntityBase
    {
       
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Aantal { get; set; }
    }
}
