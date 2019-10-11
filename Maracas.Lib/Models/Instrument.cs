using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    class Instrument
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ProductId { get; set; }
        public long TypeId { get; set; }

    }
}
