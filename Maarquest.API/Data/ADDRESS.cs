using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class ADDRESS
    {
        public ADDRESS()
        {
            CUSTOMERs = new HashSet<CUSTOMER>();
            PAYMENT_MEANs = new HashSet<PAYMENT_MEAN>();
            SUPERMARKETs = new HashSet<SUPERMARKET>();
            SUPPLIER_STORAGEs = new HashSet<SUPPLIER_STORAGE>();
            SUPPLIERs = new HashSet<SUPPLIER>();
        }

        public int ADDRESS_ID { get; set; }
        public string RECEIVER { get; set; }
        public string LIGN_ONE { get; set; }
        public string LIGN_TWO { get; set; }
        public string POSTCODE { get; set; }
        public string CITY { get; set; }
        public string REGION { get; set; }
        public string COUNTRY { get; set; }

        public virtual ICollection<CUSTOMER> CUSTOMERs { get; set; }
        public virtual ICollection<PAYMENT_MEAN> PAYMENT_MEANs { get; set; }
        public virtual ICollection<SUPERMARKET> SUPERMARKETs { get; set; }
        public virtual ICollection<SUPPLIER_STORAGE> SUPPLIER_STORAGEs { get; set; }
        public virtual ICollection<SUPPLIER> SUPPLIERs { get; set; }
    }
}
