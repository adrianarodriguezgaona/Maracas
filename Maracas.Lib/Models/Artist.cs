using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Artist
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public long? GenreId { get; set; }

        public Genre Genre { get; set; }

        public List<Cd> Cds { get; set; }

        public List<Score> Scores { get; set; }

    }
}
