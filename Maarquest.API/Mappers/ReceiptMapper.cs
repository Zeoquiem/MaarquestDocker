using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;


namespace Maarquest.API.Mappers
{
    class ReceiptMapper
    {
        public static Receipt ConvertToReceipt(RECEIPT data)
        {
            Receipt result = null;
            if (data != null)
            {
                result = new Receipt()
                {
                    ReceiptId= data.RECEIPT_ID,
                    CustomerId = data.CUSTOMER_ID,
                    UnitPrice = data.UNIT_PRICE,
                    Tax = data.TAX,
                    TotalPrice = data.TOTAL_PRICE,
                    Date = data.DATE
                };
            }
            return result;
        }
        public static RECEIPT ConvertToRECEIPT(Receipt data)
        {
            RECEIPT result = null;
            if (data != null)
            {
                result = new RECEIPT()
                {
                    RECEIPT_ID= data.ReceiptId,
                    CUSTOMER_ID = data.CustomerId,
                    UNIT_PRICE = data.UnitPrice,
                    TAX = data.Tax,
                    TOTAL_PRICE = data.TotalPrice,
                    DATE = data.Date

                };
            }
            return result;
        }

        public static List<Receipt> ConvertToReceiptList(List<RECEIPT> datas)
        {
            List<Receipt> result = new List<Receipt>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    Receipt r = ConvertToReceipt(data);
                    result.Add(r);
                }
            }
            return result;
        }

        public static List<RECEIPT> ConvertToRECEIPTList(List<Receipt> datas)
        {
            List<RECEIPT> result = new List<RECEIPT>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    RECEIPT r = ConvertToRECEIPT(data);
                    result.Add(r);
                }
            }
            return result;
        }
    }
}
