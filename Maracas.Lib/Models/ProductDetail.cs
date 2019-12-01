using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class ProductDetail : EntityBase
    {

        public string Description { get; set; }
        public Decimal Price { get; set; }
        public string Foto { get; set; }
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public int InstrumentTypeId { get; set; }
        public string InstrumentTypeName { get; set; }

        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }
    }


}
