using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.API.Models
{
    public class Supermarket
    {
        public int SupermarketId { get; set; }
        public int AddressId { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
    }
}
