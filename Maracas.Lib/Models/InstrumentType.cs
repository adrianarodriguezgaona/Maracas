using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
   public class InstrumentType
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Instrument> Instruments { get; set; }
    }
}
