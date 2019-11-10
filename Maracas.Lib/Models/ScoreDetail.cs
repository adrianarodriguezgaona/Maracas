using System;
using System.Collections.Generic;
using System.Text;

namespace Maracas.Lib.Models
{
   public class ScoreDetail : EntityBase
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public decimal ProductPrice { get; set; }
        public string Description { get; set; }
        public string Foto { get; set; }

    }
}
