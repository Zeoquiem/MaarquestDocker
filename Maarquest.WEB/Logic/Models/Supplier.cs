using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public int AddressId { get; set; }
        public string CompanyName { get; set; }
        public string CompanySign { get; set; }
        public string Siret { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public bool IsReady { get; set; }
    }
}
