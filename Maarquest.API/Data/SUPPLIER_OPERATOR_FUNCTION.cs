using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class SUPPLIER_OPERATOR_FUNCTION
    {
        public SUPPLIER_OPERATOR_FUNCTION()
        {
            SUPPLIER_OPERATORs = new HashSet<SUPPLIER_OPERATOR>();
        }

        public int SUPPLIER_OPERATOR_FUNCTION_ID { get; set; }
        public string LABEL { get; set; }
        public string AUTHORIZATION { get; set; }

        public virtual ICollection<SUPPLIER_OPERATOR> SUPPLIER_OPERATORs { get; set; }
    }
}
