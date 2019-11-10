using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Client : EntityBase
    {
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public List<Order> Orders { get; set; }


    }
   

}
