using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class Instrument
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ProductId { get; set; }

        public long ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }

        public long InstrumentTypeId  { get; set; }
        public InstrumentType InstrumentType { get; set; }



    }
}
