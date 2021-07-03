using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class PromotionCustomerMapper
    {
        public static PromotionCustomer ConvertToPromotionCustomer(PROMOTION_CUSTOMER data)
        {
            PromotionCustomer result = null;
            if (data != null)
            {
                result = new PromotionCustomer()
                {
                    PromotionId = data.PROMOTION_ID,
                    CustomerId = data.CUSTOMER_ID
                };
            }
            return result;
        }
        public static PROMOTION_CUSTOMER ConvertToPROMOTION_CUSTOMER(PromotionCustomer data)
        {
            PROMOTION_CUSTOMER result = null;
            if (data != null)
            {
                result = new PROMOTION_CUSTOMER()
                {
                    PROMOTION_ID = data.PromotionId,
                    CUSTOMER_ID = data.CustomerId

                };
            }
            return result;
        }

        public static List<PromotionCustomer> ConvertToPromotionCustomerList(List<PROMOTION_CUSTOMER> datas)
        {
            List<PromotionCustomer> result = new List<PromotionCustomer>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PromotionCustomer pc = ConvertToPromotionCustomer(data);
                    result.Add(pc);
                }
            }
            return result;
        }

        public static List<PROMOTION_CUSTOMER> ConvertToPROMOTION_CUSTOMERList(List<PromotionCustomer> datas)
        {
            List<PROMOTION_CUSTOMER> result = new List<PROMOTION_CUSTOMER>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PROMOTION_CUSTOMER pc = ConvertToPROMOTION_CUSTOMER(data);
                    result.Add(pc);
                }
            }
            return result;
        }
    }
}
