using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.API.Models
{
   public class OrderProductType
    {
        public int OrderId { get; set; }
        public int ProductTypeId { get; set; }
        public int Quantity { get; set; }
    }
}
