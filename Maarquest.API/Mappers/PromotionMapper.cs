using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class PromotionMapper
    {
        public static Promotion ConvertToPromotion(PROMOTION data)
        {
            Promotion result = null;
            if (data != null)
            {
                result = new Promotion()
                {
                    PromotionId = data.PROMOTION_ID,
                    PromotionPackId = data.PROMOTION_PACK_ID,
                    PromotionTypeId= data.PROMOTION_TYPE_ID,
                    ProductTypeId = data.PRODUCT_TYPE_ID
                };
            }
            return result;
        }
        public static PROMOTION ConvertToPROMOTION(Promotion data)
        {
            PROMOTION result = null;
            if (data != null)
            {
                result = new PROMOTION()
                {
                    PROMOTION_ID = data.PromotionId,
                    PROMOTION_PACK_ID = data.PromotionPackId,
                    PROMOTION_TYPE_ID = data.PromotionTypeId,
                    PRODUCT_TYPE_ID = data.ProductTypeId

                };
            }
            return result;
        }

        public static List<Promotion> ConvertToPromotionList(List<PROMOTION> datas)
        {
            List<Promotion> result = new List<Promotion>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    Promotion p = ConvertToPromotion(data);
                    result.Add(p);
                }
            }
            return result;
        }

        public static List<PROMOTION> ConvertToPROMOTIONList(List<Promotion> datas)
        {
            List<PROMOTION> result = new List<PROMOTION>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PROMOTION p = ConvertToPROMOTION(data);
                    result.Add(p);
                }
            }
            return result;
        }
    }
}
