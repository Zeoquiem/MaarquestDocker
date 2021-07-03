using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class ProductTypeMapper
    {
        public static ProductType ConvertToProductType(PRODUCT_TYPE data)
        {
            ProductType result = null;
            if (data != null)
            {
                result = new ProductType()
                {
                    ProductTypeId = data.PRODUCT_TYPE_ID,
                    SupplierId = data.SUPPLIER_ID,
                    Name = data.NAME,
                    ProductCategoryId = data.PRODUCT_CATEGORY_ID,
                    Details = data.DETAILS,
                    Quantity = data.QUANTITY,
                    UnitPrice = data.UNIT_PRICE,
                    Tax = data.TAX,
                    TotalPrice = data.TOTAL_PRICE
                };
            }
            return result;
        }
        public static PRODUCT_TYPE ConvertToPRODUCT_TYPE(ProductType data)
        {
            PRODUCT_TYPE result = null;
            if (data != null)
            {
                result = new PRODUCT_TYPE()
                {
                    PRODUCT_TYPE_ID = data.ProductTypeId,
                    SUPPLIER_ID = data.SupplierId,
                    NAME = data.Name,
                    PRODUCT_CATEGORY_ID = data.ProductCategoryId,
                    DETAILS = data.Details,
                    QUANTITY = data.Quantity,
                    UNIT_PRICE = data.UnitPrice,
                    TAX = data.Tax,
                    TOTAL_PRICE = data.TotalPrice
                };
            }
            return result;
        }

        public static List<ProductType> ConvertToProductTypeList(List<PRODUCT_TYPE> datas)
        {
            List<ProductType> result = new List<ProductType>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    ProductType pt = ConvertToProductType(data);
                    result.Add(pt);
                }
            }
            return result;
        }

        public static List<PRODUCT_TYPE> ConvertToPRODUCT_TYPEList(List<ProductType> datas)
        {
            List<PRODUCT_TYPE> result = new List<PRODUCT_TYPE>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PRODUCT_TYPE pt = ConvertToPRODUCT_TYPE(data);
                    result.Add(pt);
                }
            }
            return result;
        }
    }
}
