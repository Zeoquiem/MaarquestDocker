using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Models
{
    public class SupplierContactRequest
    {
        public int SupplierContactRequestId { get; set; }
        public int SupplierId { get; set; }
        public bool IsTreated { get; set; }
    }
}
