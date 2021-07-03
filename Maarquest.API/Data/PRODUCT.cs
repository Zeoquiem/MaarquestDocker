using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class PRODUCT
    {
        public PRODUCT()
        {
            CUSTOMER_KITCHENs = new HashSet<CUSTOMER_KITCHEN>();
            DELIVERY_PRODUCTs = new HashSet<DELIVERY_PRODUCT>();
        }

        public int PRODUCT_ID { get; set; }
        public int PRODUCT_TYPE_ID { get; set; }
        public DateTime EXPIRY_DATE { get; set; }
        public int POSITION_ID { get; set; }
        public int POSITION_TYPE_ID { get; set; }

        public virtual POSITION_TYPE POSITION_TYPE { get; set; }
        public virtual PRODUCT_TYPE PRODUCT_TYPE { get; set; }
        public virtual ICollection<CUSTOMER_KITCHEN> CUSTOMER_KITCHENs { get; set; }
        public virtual ICollection<DELIVERY_PRODUCT> DELIVERY_PRODUCTs { get; set; }
    }
}
