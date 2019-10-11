using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
    class Detail
    {
        public long Id { get; set; }
        public long ProductID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
