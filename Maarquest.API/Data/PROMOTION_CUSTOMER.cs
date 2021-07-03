using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class PROMOTION_CUSTOMER
    {
        public int PROMOTION_ID { get; set; }
        public int CUSTOMER_ID { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual PROMOTION PROMOTION { get; set; }
    }
}
