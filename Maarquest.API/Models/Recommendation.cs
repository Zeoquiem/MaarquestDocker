using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.API.Models
{
    public class Recommendation
    {
        public int RecommendationId { get; set; }
        public int CustomerId { get; set; }
        public int ProductTypeId { get; set; }
        public string Label { get; set; }
    }
}
