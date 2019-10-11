using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Score
    {

        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Name { get; set; }
        public long ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        public long ArtistId { get; set; }
        public Artist Artist { get; set; }

        public long GenreId { get; set; }
        public Genre Genre { get; set; }



        p


    }
}
