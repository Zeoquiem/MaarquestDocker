using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.API.Models
{
    public class PaymentMean
    {
        public int PaymentMeanId { get; set; }
        public int UserId { get; set; }
        public int UserTypeId { get; set; }
        public int AddressId { get; set; }
        public int PaymentId { get; set; }
        public int PaymentTypeId { get; set; }
        public bool IsDefault { get; set; }
    }
}
