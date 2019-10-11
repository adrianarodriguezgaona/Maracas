using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    class Score
    {

        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Name { get; set; }
        public long TypeId { get; set; }
        public long ArtistId { get; set; }


    }
}
