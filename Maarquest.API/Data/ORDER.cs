using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class ORDER
    {
        public ORDER()
        {
            DELIVERies = new HashSet<DELIVERY>();
            ORDER_PRODUCT_TYPEs = new HashSet<ORDER_PRODUCT_TYPE>();
        }

        public int ORDER_ID { get; set; }
        public int SUPPLIER_ID { get; set; }
        public int SUPERMARKET_ID { get; set; }
        public DateTime DATE { get; set; }

        public virtual SUPERMARKET SUPERMARKET { get; set; }
        public virtual SUPPLIER SUPPLIER { get; set; }
        public virtual ICollection<DELIVERY> DELIVERies { get; set; }
        public virtual ICollection<ORDER_PRODUCT_TYPE> ORDER_PRODUCT_TYPEs { get; set; }
    }
}
