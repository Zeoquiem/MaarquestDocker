using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int PositionId { get; set; }
        public int PositionTypeId { get; set; }
    }
}
