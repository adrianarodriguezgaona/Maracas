using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Genre : EntityBase
    {
        public List<Artist> Artists { get; set; }
        public List<Product> Products { get; set; }

        public Genre()
        {
            Artists = new List<Artist>();
            
        }
    }
}

