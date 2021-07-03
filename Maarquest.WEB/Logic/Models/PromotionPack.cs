using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Models
{
   public class PromotionPack
    {
        public int PromotionPackId { get; set; }
        public string Label { get; set; }
        public int ProductCategoryId { get; set; }
    }
}
