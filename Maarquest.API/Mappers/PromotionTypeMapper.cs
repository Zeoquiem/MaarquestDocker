using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class PromotionTypeMapper
    {
        public static PromotionType ConvertToPromotionType(PROMOTION_TYPE data)
        {
            PromotionType result = null;
            if (data != null)
            {
                result = new PromotionType()
                {
                    PromotionTypeId = data.PROMOTION_TYPE_ID,
                    Operation = data.OPERATION
                };
            }
            return result;
        }
        public static PROMOTION_TYPE ConvertToPROMOTION_TYPE(PromotionType data)
        {
            PROMOTION_TYPE result = null;
            if (data != null)
            {
                result = new PROMOTION_TYPE()
                {
                    PROMOTION_TYPE_ID= data.PromotionTypeId,
                   OPERATION = data.Operation

                };
            }
            return result;
        }

        public static List<PromotionType> ConvertToPromotionTypeList(List<PROMOTION_TYPE> datas)
        {
            List<PromotionType> result = new List<PromotionType>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PromotionType pt = ConvertToPromotionType(data);
                    result.Add(pt);
                }
            }
            return result;
        }

        public static List<PROMOTION_TYPE> ConvertToDELIVERYList(List<PromotionType> datas)
        {
            List<PROMOTION_TYPE> result = new List<PROMOTION_TYPE>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PROMOTION_TYPE pt = ConvertToPROMOTION_TYPE(data);
                    result.Add(pt);
                }
            }
            return result;
        }
    }
}
