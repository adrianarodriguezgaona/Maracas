using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Instrument : EntityBase
    {
        public string Name { get; set; }              
        public Product Product { get; set; }       
        public InstrumentType InstrumentType { get; set; }

    }
}
