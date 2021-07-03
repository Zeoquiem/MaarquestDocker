using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class SUPPLIER_STORAGE
    {
        public SUPPLIER_STORAGE()
        {
            SUPPLIER_OPERATORs = new HashSet<SUPPLIER_OPERATOR>();
        }

        public int SUPPLIER_STORAGE_ID { get; set; }
        public int SUPPLIER_ID { get; set; }
        public int ADDRESS_ID { get; set; }

        public virtual ADDRESS ADDRESS { get; set; }
        public virtual SUPPLIER SUPPLIER { get; set; }
        public virtual ICollection<SUPPLIER_OPERATOR> SUPPLIER_OPERATORs { get; set; }
    }
}
