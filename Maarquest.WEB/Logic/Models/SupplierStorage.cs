using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Models
{
   public class SupplierStorage
    {
        public int SupplierStorageId { get; set; }
        public int SupplierId { get; set; }
        public int AddressId { get; set; }
    }
}
