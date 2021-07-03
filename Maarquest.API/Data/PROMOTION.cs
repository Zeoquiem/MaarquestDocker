using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class PROMOTION
    {
        public PROMOTION()
        {
            PROMOTION_CUSTOMERs = new HashSet<PROMOTION_CUSTOMER>();
        }

        public int PROMOTION_ID { get; set; }
        public int PROMOTION_PACK_ID { get; set; }
        public int PROMOTION_TYPE_ID { get; set; }
        public int PRODUCT_TYPE_ID { get; set; }

        public virtual PRODUCT_TYPE PRODUCT_TYPE { get; set; }
        public virtual PROMOTION_PACK PROMOTION_PACK { get; set; }
        public virtual PROMOTION_TYPE PROMOTION_TYPE { get; set; }
        public virtual ICollection<PROMOTION_CUSTOMER> PROMOTION_CUSTOMERs { get; set; }
    }
}
