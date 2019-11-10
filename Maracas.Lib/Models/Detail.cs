using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    class ProductDetail : EntityBase
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
