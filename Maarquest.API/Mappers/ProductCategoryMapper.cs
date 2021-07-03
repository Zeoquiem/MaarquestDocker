using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class ProductCategoryMapper
    {
        public static ProductCategory ConvertToProductCategory(PRODUCT_CATEGORY data)
        {
            ProductCategory result = null;
            if (data != null)
            {
                result = new ProductCategory()
                {
                    ProductCategoryId= data.PRODUCT_CATEGORY_ID,
                    Label = data.LABEL
                };
            }
            return result;
        }
        public static PRODUCT_CATEGORY ConvertToPRODUCT_CATEGORY(ProductCategory data)
        {
            PRODUCT_CATEGORY result = null;
            if (data != null)
            {
                result = new PRODUCT_CATEGORY()
                {
                    PRODUCT_CATEGORY_ID = data.ProductCategoryId,
                    LABEL = data.Label
                };
            }
            return result;
        }

        public static List<ProductCategory> ConvertToProductCategoryList(List<PRODUCT_CATEGORY> datas)
        {
            List<ProductCategory> result = new List<ProductCategory>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    ProductCategory pc = ConvertToProductCategory(data);
                    result.Add(pc);
                }
            }
            return result;
        }

        public static List<PRODUCT_CATEGORY> ConvertToPRODUCT_CATEGORYList(List<ProductCategory> datas)
        {
            List<PRODUCT_CATEGORY> result = new List<PRODUCT_CATEGORY>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PRODUCT_CATEGORY pc = ConvertToPRODUCT_CATEGORY(data);
                    result.Add(pc);
                }
            }
            return result;
        }
    }
}
