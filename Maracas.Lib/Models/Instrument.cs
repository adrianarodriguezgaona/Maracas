using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; }              
        public Product Product { get; set; }       
        public InstrumentType InstrumentType { get; set; }

    }
}
