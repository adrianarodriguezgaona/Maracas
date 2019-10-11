using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Genre
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public List<Artist> Artists { get; set; }

        public List <Cd> Cds  { get; set; }

        public List <Score> Scores { get; set; }

    }
}

