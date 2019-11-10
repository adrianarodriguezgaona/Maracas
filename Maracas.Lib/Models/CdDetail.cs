using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class CdDetail : EntityBase
    {
        public int ProductId { get; set; }
        public decimal ProductPrice { get; set; }
        public string CdDescription { get; set; }
        public string CdFoto { get; set; }
        public int ArtistId { get; set; }
        public string ArtistName { get; set; }
        public int GenreId { get; set; }
        public string GenreName { get; set; }

    }
}
