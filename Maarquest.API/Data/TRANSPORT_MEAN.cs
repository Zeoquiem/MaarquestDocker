using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class TRANSPORT_MEAN
    {
        public TRANSPORT_MEAN()
        {
            DELIVERies = new HashSet<DELIVERY>();
        }

        public int TRANSPORT_MEAN_ID { get; set; }
        public string LABEL { get; set; }
        public double CARBON_FOOTPRINT { get; set; }

        public virtual ICollection<DELIVERY> DELIVERies { get; set; }
    }
}
