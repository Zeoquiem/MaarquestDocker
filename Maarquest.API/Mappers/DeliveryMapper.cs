using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class DeliveryMapper
    {
        public static Delivery ConvertToDelivery(DELIVERY data)
        {
            Delivery result = null;
            if (data != null)
            {
                result = new Delivery()
                {
                    DeliveryId = data.DELIVERY_ID,
                    SupplierId = data.SUPPLIER_ID,
                    SupermarketId = data.SUPERMARKET_ID,
                    OrderId = data.ORDER_ID,
                    TransportMeanId = data.TRANSPORT_MEAN_ID,
                    Date = data.DATE,
                    IsLeft = data.IS_LEFT
                };
            }
            return result;
        }
        public static DELIVERY ConvertToDELIVERY(Delivery data)
        {
            DELIVERY result = null;
            if (data != null)
            {
                result = new DELIVERY()
                {
                    DELIVERY_ID = data.DeliveryId,
                    SUPPLIER_ID = data.SupplierId,
                    SUPERMARKET_ID = data.SupermarketId,
                    ORDER_ID = data.OrderId,
                    TRANSPORT_MEAN_ID = data.TransportMeanId,
                    DATE = data.Date,
                   IS_LEFT = data.IsLeft

                };
            }
            return result;
        }

        public static List<Delivery> ConvertToDeliveryList(List<DELIVERY> datas)
        {
            List<Delivery> result = new List<Delivery>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    Delivery d = ConvertToDelivery(data);
                    result.Add(d);
                }
            }
            return result;
        }

        public static List<DELIVERY> ConvertToDELIVERYList(List<Delivery> datas)
        {
            List<DELIVERY> result = new List<DELIVERY>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    DELIVERY d = ConvertToDELIVERY(data);
                    result.Add(d);
                }
            }
            return result;
        }
    }
}
