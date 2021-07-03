using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class POSITION_TYPE
    {
        public POSITION_TYPE()
        {
            PRODUCTs = new HashSet<PRODUCT>();
        }

        public int POSITION_TYPE_ID { get; set; }
        public string LABEL { get; set; }

        public virtual ICollection<PRODUCT> PRODUCTs { get; set; }
    }
}
