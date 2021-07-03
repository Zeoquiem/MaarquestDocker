using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.API.Models
{
    public class CreditCard
    {
        public int CreditCardId { get; set; }
        public string CardNumber { get; set; }
        public string CardName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int SecurityCode { get; set; }
    }
}
