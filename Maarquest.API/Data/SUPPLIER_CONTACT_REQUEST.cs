using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class SUPPLIER_CONTACT_REQUEST
    {
        public int SUPPLIER_CONTACT_REQUEST_ID { get; set; }
        public int SUPPLIER_ID { get; set; }
        public bool IS_TREATED { get; set; }

        public virtual SUPPLIER SUPPLIER { get; set; }
    }
}
