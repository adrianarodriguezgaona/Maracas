using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
   public class Product
    {
        public int Id { get; set; }       
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public string Foto { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public Order Order { get; set; }

    }
}
