using System;
using System.Collections.Generic;

#nullable disable

namespace Maarquest.API.Data
{
    public partial class CREDIT_CARD
    {
        public int CREDIT_CARD_ID { get; set; }
        public string CARD_NUMBER { get; set; }
        public string CARD_NAME { get; set; }
        public DateTime EXPIRY_DATE { get; set; }
        public int SECURITY_CODE { get; set; }
    }
}
