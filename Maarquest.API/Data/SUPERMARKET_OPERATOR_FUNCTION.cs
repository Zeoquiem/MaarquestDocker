using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class SUPERMARKET_OPERATOR_FUNCTION
    {
        public SUPERMARKET_OPERATOR_FUNCTION()
        {
            SUPERMARKET_OPERATORs = new HashSet<SUPERMARKET_OPERATOR>();
        }

        public int SUPERMARKET_OPERATOR_FUNCTION_ID { get; set; }
        public string LABEL { get; set; }
        public string AUTHORIZATION { get; set; }

        public virtual ICollection<SUPERMARKET_OPERATOR> SUPERMARKET_OPERATORs { get; set; }
    }
}
