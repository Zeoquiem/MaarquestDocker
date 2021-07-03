using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.API.Models
{
    public class SupplierProductRequest
    {
        public int SupplierProductRequestId { get; set; }
        public int SupplierId { get; set; }
        public int ProductTypeId { get; set; }
        public bool IsTreated { get; set; }
    }
}
