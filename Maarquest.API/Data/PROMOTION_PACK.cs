using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class PROMOTION_PACK
    {
        public PROMOTION_PACK()
        {
            PROMOTIONs = new HashSet<PROMOTION>();
        }

        public int PROMOTION_PACK_ID { get; set; }
        public string LABEL { get; set; }
        public int PRODUCT_CATEGORY_ID { get; set; }

        public virtual PRODUCT_CATEGORY PRODUCT_CATEGORY { get; set; }
        public virtual ICollection<PROMOTION> PROMOTIONs { get; set; }
    }
}
