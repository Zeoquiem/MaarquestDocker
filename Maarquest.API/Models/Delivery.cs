using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.API.Models
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public int SupplierId { get; set; }
        public int SupermarketId { get; set; }
        public int OrderId { get; set; }
        public int TransportMeanId { get; set; }
        public DateTime Date { get; set; }
        public bool IsLeft { get; set; }
    }
}
