using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class CUSTOMER
    {
        public CUSTOMER()
        {
            CUSTOMER_KITCHENs = new HashSet<CUSTOMER_KITCHEN>();
            PROMOTION_CUSTOMERs = new HashSet<PROMOTION_CUSTOMER>();
            RECEIPTs = new HashSet<RECEIPT>();
            RECOMMENDATIONs = new HashSet<RECOMMENDATION>();
        }

        public int CUSTOMER_ID { get; set; }
        public int? ADDRESS_ID { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string USERNAME { get; set; }
        public string MAIL { get; set; }
        public string PASSWORD { get; set; }
        public DateTime BIRTHDATE { get; set; }
        public string GENDER { get; set; }
        public string TEL { get; set; }

        public virtual ADDRESS ADDRESS { get; set; }
        public virtual ICollection<CUSTOMER_KITCHEN> CUSTOMER_KITCHENs { get; set; }
        public virtual ICollection<PROMOTION_CUSTOMER> PROMOTION_CUSTOMERs { get; set; }
        public virtual ICollection<RECEIPT> RECEIPTs { get; set; }
        public virtual ICollection<RECOMMENDATION> RECOMMENDATIONs { get; set; }
    }
}
