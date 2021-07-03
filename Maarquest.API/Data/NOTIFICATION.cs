using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class NOTIFICATION
    {
        public int NOTIFICATION_ID { get; set; }
        public int USER_ID { get; set; }
        public int USER_TYPE_ID { get; set; }
        public string LABEL { get; set; }

        public virtual USER_TYPE USER_TYPE { get; set; }
    }
}
