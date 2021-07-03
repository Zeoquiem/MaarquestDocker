using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class PRODUCT_CATEGORY
    {
        public PRODUCT_CATEGORY()
        {
            PRODUCT_TYPEs = new HashSet<PRODUCT_TYPE>();
            PROMOTION_PACKs = new HashSet<PROMOTION_PACK>();
            SUPERMARKET_SHELves = new HashSet<SUPERMARKET_SHELF>();
        }

        public int PRODUCT_CATEGORY_ID { get; set; }
        public string LABEL { get; set; }

        public virtual ICollection<PRODUCT_TYPE> PRODUCT_TYPEs { get; set; }
        public virtual ICollection<PROMOTION_PACK> PROMOTION_PACKs { get; set; }
        public virtual ICollection<SUPERMARKET_SHELF> SUPERMARKET_SHELves { get; set; }
    }
}
