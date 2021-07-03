using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.API.Models
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public int CustomerId { get; set; }
        public double UnitPrice { get; set; }
        public double Tax { get; set; }
        public double TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
