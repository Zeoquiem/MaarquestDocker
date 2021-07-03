using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class RecommendationMapper
    {
        public static Recommendation ConvertToRecommendation(RECOMMENDATION data)
        {
            Recommendation result = null;
            if (data != null)
            {
                result = new Recommendation()
                {
                    RecommendationId = data.RECOMMENDATION_ID,
                    CustomerId = data.CUSTOMER_ID,
                    ProductTypeId = data.PRODUCT_TYPE_ID,
                    Label = data.LABEL
                };
            }
            return result;
        }
        public static RECOMMENDATION ConvertToRECOMMENDATION(Recommendation data)
        {
            RECOMMENDATION result = null;
            if (data != null)
            {
                result = new RECOMMENDATION()
                {
                    RECOMMENDATION_ID = data.RecommendationId,
                    CUSTOMER_ID = data.CustomerId,
                    PRODUCT_TYPE_ID = data.ProductTypeId,
                    LABEL = data.Label

                };
            }
            return result;
        }

        public static List<Recommendation> ConvertToRecommendationList(List<RECOMMENDATION> datas)
        {
            List<Recommendation> result = new List<Recommendation>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    Recommendation r = ConvertToRecommendation(data);
                    result.Add(r);
                }
            }
            return result;
        }

        public static List<RECOMMENDATION> ConvertToRECOMMENDATIONList(List<Recommendation> datas)
        {
            List<RECOMMENDATION> result = new List<RECOMMENDATION>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    RECOMMENDATION r = ConvertToRECOMMENDATION(data);
                    result.Add(r);
                }
            }
            return result;
        }
    }
}
