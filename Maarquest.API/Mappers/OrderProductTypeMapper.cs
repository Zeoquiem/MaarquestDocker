using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;


namespace Maarquest.API.Mappers
{
    class OrderProductTypeMapper
    {
        public static OrderProductType ConvertToOrderProductType(ORDER_PRODUCT_TYPE data)
        {
            OrderProductType result = null;
            if (data != null)
            {
                result = new OrderProductType()
                {
                    OrderId = data.ORDER_ID,
                    ProductTypeId = data.PRODUCT_TYPE_ID,
                    Quantity = data.QUANTITY
                };
            }
            return result;
        }
        public static ORDER_PRODUCT_TYPE ConvertToORDER_PRODUCT_TYPE(OrderProductType data)
        {
            ORDER_PRODUCT_TYPE result = null;
            if (data != null)
            {
                result = new ORDER_PRODUCT_TYPE()
                {
                    ORDER_ID = data.OrderId,
                    PRODUCT_TYPE_ID = data.ProductTypeId,
                    QUANTITY = data.Quantity

                };
            }
            return result;
        }

        public static List<OrderProductType> ConvertToOrderProductTypeList(List<ORDER_PRODUCT_TYPE> datas)
        {
            List<OrderProductType> result = new List<OrderProductType>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    OrderProductType opt = ConvertToOrderProductType(data);
                    result.Add(opt);
                }
            }
            return result;
        }

        public static List<ORDER_PRODUCT_TYPE> ConvertToORDER_PRODUCT_TYPEList(List<OrderProductType> datas)
        {
            List<ORDER_PRODUCT_TYPE> result = new List<ORDER_PRODUCT_TYPE>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    ORDER_PRODUCT_TYPE opt = ConvertToORDER_PRODUCT_TYPE(data);
                    result.Add(opt);
                }
            }
            return result;
        }
    }
}
