using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class PromotionPackMapper
    {
        public static PromotionPack ConvertToPromotionPack(PROMOTION_PACK data)
        {
            PromotionPack result = null;
            if (data != null)
            {
                result = new PromotionPack()
                {
                    PromotionPackId = data.PROMOTION_PACK_ID,
                    Label = data.LABEL,
                    ProductCategoryId = data.PRODUCT_CATEGORY_ID
                };
            }
            return result;
        }
        public static PROMOTION_PACK ConvertToPROMOTION_PACK(PromotionPack data)
        {
            PROMOTION_PACK result = null;
            if (data != null)
            {
                result = new PROMOTION_PACK()
                {
                    PROMOTION_PACK_ID = data.PromotionPackId,
                    LABEL = data.Label,
                    PRODUCT_CATEGORY_ID = data.ProductCategoryId

                };
            }
            return result;
        }

        public static List<PromotionPack> ConvertToPromotionPackList(List<PROMOTION_PACK> datas)
        {
            List<PromotionPack> result = new List<PromotionPack>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PromotionPack pp = ConvertToPromotionPack(data);
                    result.Add(pp);
                }
            }
            return result;
        }

        public static List<PROMOTION_PACK> ConvertToPROMOTION_PACKYList(List<PromotionPack> datas)
        {
            List<PROMOTION_PACK> result = new List<PROMOTION_PACK>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PROMOTION_PACK pp = ConvertToPROMOTION_PACK(data);
                    result.Add(pp);
                }
            }
            return result;
        }
    }
}
