using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Instrument : EntityBase
    {
        public Product Product { get; set; }       
        public InstrumentType InstrumentType { get; set; }

    }
}
