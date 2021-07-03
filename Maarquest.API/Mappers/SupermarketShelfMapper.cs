using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class SupermarketShelfMapper
    {
        public static SupermarketShelf ConvertToSupermarketShelf(SUPERMARKET_SHELF data)
        {
            SupermarketShelf result = null;
            if (data != null)
            {
                result = new SupermarketShelf()
                {
                    SupermarketShelfId = data.SUPERMARKET_SHELF_ID,
                    SupermarketId = data.SUPERMARKET_ID,
                    ProductCategoryId = data.PRODUCT_CATEGORY_ID
                };
            }
            return result;
        }
        public static SUPERMARKET_SHELF ConvertToSUPERMARKET_SHELF(SupermarketShelf data)
        {
            SUPERMARKET_SHELF result = null;
            if (data != null)
            {
                result = new SUPERMARKET_SHELF()
                {
                    SUPERMARKET_SHELF_ID = data.SupermarketShelfId,
                    SUPERMARKET_ID = data.SupermarketId,
                    PRODUCT_CATEGORY_ID = data.ProductCategoryId

                };
            }
            return result;
        }

        public static List<SupermarketShelf> ConvertToSupermarketShelfList(List<SUPERMARKET_SHELF> datas)
        {
            List<SupermarketShelf> result = new List<SupermarketShelf>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SupermarketShelf ss = ConvertToSupermarketShelf(data);
                    result.Add(ss);
                }
            }
            return result;
        }

        public static List<SUPERMARKET_SHELF> ConvertToDELIVERYList(List<SupermarketShelf> datas)
        {
            List<SUPERMARKET_SHELF> result = new List<SUPERMARKET_SHELF>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SUPERMARKET_SHELF ss = ConvertToSUPERMARKET_SHELF(data);
                    result.Add(ss);
                }
            }
            return result;
        }
    }
}
