using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class SUPERMARKET_OPERATOR
    {
        public int SUPERMARKET_OPERATOR_ID { get; set; }
        public int SUPERMARKET_ID { get; set; }
        public int SUPERMARKET_OPERATOR_FUNCTION_ID { get; set; }
        public string FIRSTNAME { get; set; }
        public string LASTNAME { get; set; }
        public string USERNAME { get; set; }
        public string MAIL { get; set; }
        public string PASSWORD { get; set; }
        public DateTime BIRTHDATE { get; set; }
        public string GENDER { get; set; }
        public string TEL { get; set; }

        public virtual SUPERMARKET SUPERMARKET { get; set; }
        public virtual SUPERMARKET_OPERATOR_FUNCTION SUPERMARKET_OPERATOR_FUNCTION { get; set; }
    }
}
