using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Order
    {
        public long Id { get; set; }

        public long ClientId { get; set; }

        public Client Client { get; set; }

        //public List <Product> Products { get; set; }



    }
}
