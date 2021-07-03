using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class DeliveryProductMapper
    {
        public static DeliveryProduct ConvertToDeliveryProduct(DELIVERY_PRODUCT data)
        {
            DeliveryProduct result = null;
            if (data != null)
            {
                result = new DeliveryProduct()
                {
                    DeliveryId = data.DELIVERY_ID,
                    ProductId = data.PRODUCT_ID,
                   
                };
            }
            return result;
        }
        public static DELIVERY_PRODUCT ConvertToDELIVERY_PRODUCT(DeliveryProduct data)
        {
            DELIVERY_PRODUCT result = null;
            if (data != null)
            {
                result = new DELIVERY_PRODUCT()
                {
                    DELIVERY_ID = data.DeliveryId,
                    PRODUCT_ID = data.ProductId,
 
                };
            }
            return result;
        }

        public static List<DeliveryProduct> ConvertToDeliveryProductList(List<DELIVERY_PRODUCT> datas)
        {
            List<DeliveryProduct> result = new List<DeliveryProduct>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    DeliveryProduct dp = ConvertToDeliveryProduct(data);
                    result.Add(dp);
                }
            }
            return result;
        }

        public static List<DELIVERY_PRODUCT> ConvertToDELIVERYList(List<DeliveryProduct> datas)
        {
            List<DELIVERY_PRODUCT> result = new List<DELIVERY_PRODUCT>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    DELIVERY_PRODUCT dp = ConvertToDELIVERY_PRODUCT(data);
                    result.Add(dp);
                }
            }
            return result;
        }
    }
}
