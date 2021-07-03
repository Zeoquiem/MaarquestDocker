using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.API.Models
{
   public class SupermarketShelf
    {
        public int SupermarketShelfId { get; set; }
        public int SupermarketId { get; set; }
        public int ProductCategoryId { get; set; }
    }
}
