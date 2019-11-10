using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Order : EntityBase
    {
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public List <Product> Products { get; set; }

    }
}
