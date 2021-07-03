using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class SUPPLIER_PRODUCT_REQUEST
    {
        public int SUPPLIER_PRODUCT_REQUEST_ID { get; set; }
        public int SUPPLIER_ID { get; set; }
        public int PRODUCT_TYPE_ID { get; set; }
        public bool IS_TREATED { get; set; }

        public virtual PRODUCT_TYPE PRODUCT_TYPE { get; set; }
        public virtual SUPPLIER SUPPLIER { get; set; }
    }
}
