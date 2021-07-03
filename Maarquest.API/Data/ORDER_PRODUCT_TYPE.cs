using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class ORDER_PRODUCT_TYPE
    {
        public int ORDER_ID { get; set; }
        public int PRODUCT_TYPE_ID { get; set; }
        public int QUANTITY { get; set; }

        public virtual ORDER ORDER { get; set; }
        public virtual PRODUCT_TYPE PRODUCT_TYPE { get; set; }
    }
}
