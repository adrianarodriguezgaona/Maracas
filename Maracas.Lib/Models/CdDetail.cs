using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class CdDetail
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ProductId { get; set; }
        public decimal ProductPrice { get; set; }
        public long ArtistId { get; set; }
        public string ArtistName { get; set; }
        public long? GenreId { get; set; }
        public string GenreName { get; set; }

    }
}
