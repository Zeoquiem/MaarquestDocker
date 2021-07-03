using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class ProductMapper
    {
        public static Product ConvertToProduct(PRODUCT data)
        {
            Product result = null;
            if (data != null)
            {
                result = new Product()
                {
                    ProductId = data.PRODUCT_ID,
                    ProductTypeId = data.PRODUCT_TYPE_ID,
                    ExpiryDate = data.EXPIRY_DATE,
                    PositionId = data.POSITION_ID,
                    PositionTypeId = data.POSITION_TYPE_ID
                };
            }
            return result;
        }
        public static PRODUCT ConvertToPRODUCT(Product data)
        {
            PRODUCT result = null;
            if (data != null)
            {
                result = new PRODUCT()
                {
                    PRODUCT_ID = data.ProductId,
                    PRODUCT_TYPE_ID = data.ProductTypeId,
                    EXPIRY_DATE = data.ExpiryDate,
                    POSITION_ID = data.PositionId,
                    POSITION_TYPE_ID = data.PositionTypeId
                };
            }
            return result;
        }

        public static List<Product> ConvertToProductList(List<PRODUCT> datas)
        {
            List<Product> result = new List<Product>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    Product p = ConvertToProduct(data);
                    result.Add(p);
                }
            }
            return result;
        }

        public static List<PRODUCT> ConvertToPRODUCTList(List<Product> datas)
        {
            List<PRODUCT> result = new List<PRODUCT>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PRODUCT p = ConvertToPRODUCT(data);
                    result.Add(p);
                }
            }
            return result;
        }
    }
}
