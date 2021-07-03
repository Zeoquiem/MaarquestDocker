using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class SUPERMARKET_SHELF
    {
        public int SUPERMARKET_SHELF_ID { get; set; }
        public int SUPERMARKET_ID { get; set; }
        public int PRODUCT_CATEGORY_ID { get; set; }

        public virtual PRODUCT_CATEGORY PRODUCT_CATEGORY { get; set; }
        public virtual SUPERMARKET SUPERMARKET { get; set; }
    }
}
