using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class SUPERMARKET_STOCK
    {
        public int SUPERMARKET_STOCK_ID { get; set; }
        public int SUPERMARKET_ID { get; set; }

        public virtual SUPERMARKET SUPERMARKET { get; set; }
    }
}
