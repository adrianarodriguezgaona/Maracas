using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
   public class InstrumentType : EntityBase
    {
        public List<Product> Products { get; set; }

        public InstrumentType()
        {
            Products = new List<Product>();
        }

    }
}
