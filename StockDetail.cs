using System;
using System.Collections.Generic;
using System.Text;

namespace ZHElott
{
    public class StockDetail
    {
        public int StoreSk { get; set; }

        public int ProductFk { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public int? Quantity { get; set; }
    }
}
