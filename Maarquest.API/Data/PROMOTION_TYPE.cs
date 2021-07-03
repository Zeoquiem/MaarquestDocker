using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class PROMOTION_TYPE
    {
        public PROMOTION_TYPE()
        {
            PROMOTIONs = new HashSet<PROMOTION>();
        }

        public int PROMOTION_TYPE_ID { get; set; }
        public string OPERATION { get; set; }

        public virtual ICollection<PROMOTION> PROMOTIONs { get; set; }
    }
}
