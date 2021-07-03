using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class CUSTOMER_KITCHEN
    {
        public int CUSTOMER_ID { get; set; }
        public int PRODUCT_ID { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual PRODUCT PRODUCT { get; set; }
    }
}
