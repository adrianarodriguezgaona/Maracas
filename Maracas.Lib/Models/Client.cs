using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Client : EntityBase
    {
      
        public string Password { get; set; }
        public string Email { get; set; }
        public Guid UserId { get; set; }
        public List<Order> Orders { get; set; }

        public Client()
        {
            Orders = new List<Order>();
        }


    }
   

}
