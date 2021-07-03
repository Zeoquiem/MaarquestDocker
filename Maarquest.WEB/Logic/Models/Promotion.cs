using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Models
{
   public class Promotion
    {
        public int PromotionId { get; set; }
        public int PromotionPackId { get; set; }
        public int PromotionTypeId { get; set; }
        public int ProductTypeId { get; set; }
    }
}
