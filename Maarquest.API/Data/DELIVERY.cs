using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class DELIVERY
    {
        public DELIVERY()
        {
            DELIVERY_PRODUCTs = new HashSet<DELIVERY_PRODUCT>();
        }

        public int DELIVERY_ID { get; set; }
        public int SUPPLIER_ID { get; set; }
        public int SUPERMARKET_ID { get; set; }
        public int ORDER_ID { get; set; }
        public int TRANSPORT_MEAN_ID { get; set; }
        public DateTime DATE { get; set; }
        public bool IS_LEFT { get; set; }

        public virtual ORDER ORDER { get; set; }
        public virtual SUPERMARKET SUPERMARKET { get; set; }
        public virtual SUPPLIER SUPPLIER { get; set; }
        public virtual TRANSPORT_MEAN TRANSPORT_MEAN { get; set; }
        public virtual ICollection<DELIVERY_PRODUCT> DELIVERY_PRODUCTs { get; set; }
    }
}
