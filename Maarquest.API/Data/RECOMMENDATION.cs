using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class RECOMMENDATION
    {
        public int RECOMMENDATION_ID { get; set; }
        public int CUSTOMER_ID { get; set; }
        public int PRODUCT_TYPE_ID { get; set; }
        public string LABEL { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual PRODUCT_TYPE PRODUCT_TYPE { get; set; }
    }
}
