using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class SUPPLIER
    {
        public SUPPLIER()
        {
            DELIVERies = new HashSet<DELIVERY>();
            ORDERs = new HashSet<ORDER>();
            PRODUCT_TYPEs = new HashSet<PRODUCT_TYPE>();
            SUPPLIER_CONTACT_REQUESTs = new HashSet<SUPPLIER_CONTACT_REQUEST>();
            SUPPLIER_OPERATORs = new HashSet<SUPPLIER_OPERATOR>();
            SUPPLIER_PRODUCT_REQUESTs = new HashSet<SUPPLIER_PRODUCT_REQUEST>();
            SUPPLIER_STORAGEs = new HashSet<SUPPLIER_STORAGE>();
        }

        public int SUPPLIER_ID { get; set; }
        public int ADDRESS_ID { get; set; }
        public string COMPANY_NAME { get; set; }
        public string COMPANY_SIGN { get; set; }
        public string SIRET { get; set; }
        public string TEL { get; set; }
        public string FAX { get; set; }
        public bool IS_READY { get; set; }

        public virtual ADDRESS ADDRESS { get; set; }
        public virtual ICollection<DELIVERY> DELIVERies { get; set; }
        public virtual ICollection<ORDER> ORDERs { get; set; }
        public virtual ICollection<PRODUCT_TYPE> PRODUCT_TYPEs { get; set; }
        public virtual ICollection<SUPPLIER_CONTACT_REQUEST> SUPPLIER_CONTACT_REQUESTs { get; set; }
        public virtual ICollection<SUPPLIER_OPERATOR> SUPPLIER_OPERATORs { get; set; }
        public virtual ICollection<SUPPLIER_PRODUCT_REQUEST> SUPPLIER_PRODUCT_REQUESTs { get; set; }
        public virtual ICollection<SUPPLIER_STORAGE> SUPPLIER_STORAGEs { get; set; }
    }
}
