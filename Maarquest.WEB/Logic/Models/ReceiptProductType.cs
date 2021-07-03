using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Models
{
   public class ReceiptProductType
    {
        public int ReceiptId { get; set; }
        public int ProductTypeId { get; set; }
        public int Quantity { get; set; }
    }
}
