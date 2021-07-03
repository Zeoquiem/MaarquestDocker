using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Models
{
    public class ProductType
    {
        public int ProductTypeId { get; set; }
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public int ProductCategoryId { get; set; }
        public string Details { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double Tax { get; set; }
        public double TotalPrice { get; set; }
    }
}
