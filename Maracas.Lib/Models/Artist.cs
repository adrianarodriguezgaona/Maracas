using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Artist : EntityBase
    {
        public int GenreId { get; set; }    
        public Genre Genre { get; set; }
        public List<Product> Products { get; set; }

        public Artist()
        {
            Products = new List<Product>();
        }

    }
}

