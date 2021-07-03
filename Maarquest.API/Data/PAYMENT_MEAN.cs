using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class PAYMENT_MEAN
    {
        public int PAYMENT_MEAN_ID { get; set; }
        public int USER_ID { get; set; }
        public int USER_TYPE_ID { get; set; }
        public int ADDRESS_ID { get; set; }
        public int PAYMENT_ID { get; set; }
        public int PAYMENT_TYPE_ID { get; set; }
        public bool IS_DEFAULT { get; set; }

        public virtual ADDRESS ADDRESS { get; set; }
        public virtual USER_TYPE USER_TYPE { get; set; }
    }
}
