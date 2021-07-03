using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class SUPERMARKET
    {
        public SUPERMARKET()
        {
            DELIVERies = new HashSet<DELIVERY>();
            ORDERs = new HashSet<ORDER>();
            SUPERMARKET_OPERATORs = new HashSet<SUPERMARKET_OPERATOR>();
            SUPERMARKET_SHELves = new HashSet<SUPERMARKET_SHELF>();
            SUPERMARKET_STOCKs = new HashSet<SUPERMARKET_STOCK>();
        }

        public int SUPERMARKET_ID { get; set; }
        public int ADDRESS_ID { get; set; }
        public string TEL { get; set; }
        public string FAX { get; set; }

        public virtual ADDRESS ADDRESS { get; set; }
        public virtual ICollection<DELIVERY> DELIVERies { get; set; }
        public virtual ICollection<ORDER> ORDERs { get; set; }
        public virtual ICollection<SUPERMARKET_OPERATOR> SUPERMARKET_OPERATORs { get; set; }
        public virtual ICollection<SUPERMARKET_SHELF> SUPERMARKET_SHELves { get; set; }
        public virtual ICollection<SUPERMARKET_STOCK> SUPERMARKET_STOCKs { get; set; }
    }
}
