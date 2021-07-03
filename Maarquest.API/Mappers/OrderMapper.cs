using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class OrderMapper
    {
        public static Order ConvertToOrder(ORDER data)
        {
            Order result = null;
            if (data != null)
            {
                result = new Order()
                {
                    OrderId = data.ORDER_ID,
                    SupplierId = data.SUPPLIER_ID,
                    SupermarketId = data.SUPERMARKET_ID,
                    Date = data.DATE
                };
            }
            return result;
        }
        public static ORDER ConvertToORDER(Order data)
        {
            ORDER result = null;
            if (data != null)
            {
                result = new ORDER()
                {
                    ORDER_ID = data.OrderId,
                    SUPPLIER_ID = data.SupplierId,
                    SUPERMARKET_ID = data.SupermarketId,
                    DATE = data.Date

                };
            }
            return result;
        }

        public static List<Order> ConvertToOrderList(List<ORDER> datas)
        {
            List<Order> result = new List<Order>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    Order o = ConvertToOrder(data);
                    result.Add(o);
                }
            }
            return result;
        }

        public static List<ORDER> ConvertToORDERList(List<Order> datas)
        {
            List<ORDER> result = new List<ORDER>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    ORDER o = ConvertToORDER(data);
                    result.Add(o);
                }
            }
            return result;
        }
    }
}
