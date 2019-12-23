using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
   public class Product : EntityBase
    {
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public string Foto { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public int InstrumentTypeId { get; set; }
        public InstrumentType InstrumentType { get; set; }

    }

}

