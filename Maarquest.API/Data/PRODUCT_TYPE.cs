using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class PRODUCT_TYPE
    {
        public PRODUCT_TYPE()
        {
            ORDER_PRODUCT_TYPEs = new HashSet<ORDER_PRODUCT_TYPE>();
            PRODUCTs = new HashSet<PRODUCT>();
            PROMOTIONs = new HashSet<PROMOTION>();
            RECEIPT_PRODUCT_TYPEs = new HashSet<RECEIPT_PRODUCT_TYPE>();
            RECOMMENDATIONs = new HashSet<RECOMMENDATION>();
            SUPPLIER_PRODUCT_REQUESTs = new HashSet<SUPPLIER_PRODUCT_REQUEST>();
        }

        public int PRODUCT_TYPE_ID { get; set; }
        public int SUPPLIER_ID { get; set; }
        public string NAME { get; set; }
        public int PRODUCT_CATEGORY_ID { get; set; }
        public string DETAILS { get; set; }
        public int QUANTITY { get; set; }
        public double UNIT_PRICE { get; set; }
        public double TAX { get; set; }
        public double TOTAL_PRICE { get; set; }

        public virtual PRODUCT_CATEGORY PRODUCT_CATEGORY { get; set; }
        public virtual SUPPLIER SUPPLIER { get; set; }
        public virtual ICollection<ORDER_PRODUCT_TYPE> ORDER_PRODUCT_TYPEs { get; set; }
        public virtual ICollection<PRODUCT> PRODUCTs { get; set; }
        public virtual ICollection<PROMOTION> PROMOTIONs { get; set; }
        public virtual ICollection<RECEIPT_PRODUCT_TYPE> RECEIPT_PRODUCT_TYPEs { get; set; }
        public virtual ICollection<RECOMMENDATION> RECOMMENDATIONs { get; set; }
        public virtual ICollection<SUPPLIER_PRODUCT_REQUEST> SUPPLIER_PRODUCT_REQUESTs { get; set; }
    }
}
