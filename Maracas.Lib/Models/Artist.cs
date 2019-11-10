using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Artist : EntityBase
    {
        public string Name { get; set; }

        public long? GenreId { get; set; }

        public Genre Genre { get; set; }



       

    }
}
