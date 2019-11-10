using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Cd : EntityBase
    {
        public string Name { get; set; }             
        public Product Product { get; set; }
        public Artist Artist { get; set; }              
        public Genre Genre { get; set; }
        
    }
}
