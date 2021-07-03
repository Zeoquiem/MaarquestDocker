using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class USER_TYPE
    {
        public USER_TYPE()
        {
            NOTIFICATIONs = new HashSet<NOTIFICATION>();
            PAYMENT_MEANs = new HashSet<PAYMENT_MEAN>();
        }

        public int USER_TYPE_ID { get; set; }
        public string LABEL { get; set; }

        public virtual ICollection<NOTIFICATION> NOTIFICATIONs { get; set; }
        public virtual ICollection<PAYMENT_MEAN> PAYMENT_MEANs { get; set; }
    }
}
