using System;
using System.Collections.Generic;
using System.Text;

namespace OG.Domain.dtos
{
    public class BidRequestDTO
    {
        public string CustomerName { get; set; }
        public decimal UnitPrice { get; set; }
        public string ItemName { get; set; }
    }
}
