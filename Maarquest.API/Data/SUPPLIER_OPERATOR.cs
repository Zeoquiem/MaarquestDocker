using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class SUPPLIER_OPERATOR
    {
        public int SUPPLIER_OPERATOR_ID { get; set; }
        public int SUPPLIER_ID { get; set; }
        public int SUPPLIER_STORAGE_ID { get; set; }
        public int SUPPLIER_OPERATOR_FUNCTION_ID { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string USERNAME { get; set; }
        public string MAIL { get; set; }
        public string PASSWORD { get; set; }
        public DateTime BIRTHDATE { get; set; }
        public string GENDER { get; set; }
        public string TEL { get; set; }

        public virtual SUPPLIER SUPPLIER { get; set; }
        public virtual SUPPLIER_OPERATOR_FUNCTION SUPPLIER_OPERATOR_FUNCTION { get; set; }
        public virtual SUPPLIER_STORAGE SUPPLIER_STORAGE { get; set; }
    }
}
