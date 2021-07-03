using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class DELIVERY_PRODUCT
    {
        public int DELIVERY_ID { get; set; }
        public int PRODUCT_ID { get; set; }

        public virtual DELIVERY DELIVERY { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
    }
}
