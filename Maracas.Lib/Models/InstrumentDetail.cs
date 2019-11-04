using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class InstrumentDetail
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long ProductId { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
