using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class RECEIPT
    {
        public RECEIPT()
        {
            RECEIPT_PRODUCT_TYPEs = new HashSet<RECEIPT_PRODUCT_TYPE>();
        }

        public int RECEIPT_ID { get; set; }
        public int CUSTOMER_ID { get; set; }
        public double UNIT_PRICE { get; set; }
        public double TAX { get; set; }
        public double TOTAL_PRICE { get; set; }
        public DateTime DATE { get; set; }

        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual ICollection<RECEIPT_PRODUCT_TYPE> RECEIPT_PRODUCT_TYPEs { get; set; }
    }
}
