
using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    public class InstrumentDetail : EntityBase
    {
        public int ProductId { get; set; }
        public decimal ProductPrice { get; set; }
        public string Description { get; set; }
        public string Foto { get; set; }

    }
}
