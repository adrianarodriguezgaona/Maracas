using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Genre : EntityBase
    {
        public List<Artist> Artists { get; set; }
        public List <Score> Scores { get; set; }

    }
}

