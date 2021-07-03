using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    public class SupermarketStockMapper
    {
        public static SupermarketStock ConvertToSupermarketStock(SUPERMARKET_STOCK data)
        {
            SupermarketStock result = null;
            if (data != null)
            {
                result = new SupermarketStock()
                {
                    SupermarketStockId = data.SUPERMARKET_STOCK_ID,
                    SupermarketId = data.SUPERMARKET_ID
                };
            }
            return result;
        }
        public static SUPERMARKET_STOCK ConvertToSUPERMARKET_STOCK(SupermarketStock data)
        {
            SUPERMARKET_STOCK result = null;
            if (data != null)
            {
                result = new SUPERMARKET_STOCK()
                {
                    SUPERMARKET_STOCK_ID = data.SupermarketStockId,
                    SUPERMARKET_ID = data.SupermarketId
                };
            }
            return result;
        }

        public static List<SupermarketStock> ConvertToSupermarketStockList(List<SUPERMARKET_STOCK> datas)
        {
            List<SupermarketStock> result = new List<SupermarketStock>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SupermarketStock ss = ConvertToSupermarketStock(data);
                    result.Add(ss);
                }
            }
            return result;
        }

        public static List<SUPERMARKET_STOCK> ConvertToSUPERMARKET_STOCKList(List<SupermarketStock> datas)
        {
            List<SUPERMARKET_STOCK> result = new List<SUPERMARKET_STOCK>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SUPERMARKET_STOCK ss = ConvertToSUPERMARKET_STOCK(data);
                    result.Add(ss);
                }
            }
            return result;
        }
    }
}
