using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
   public class InstrumentType : EntityBase
    {
        public string Name { get; set; }
        public List<Instrument> Instruments { get; set; }
    }
}
