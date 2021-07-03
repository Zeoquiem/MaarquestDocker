using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class ReceiptProductTypeMapper
    {
        public static ReceiptProductType ConvertToReceiptProductType(RECEIPT_PRODUCT_TYPE data)
        {
            ReceiptProductType result = null;
            if (data != null)
            {
                result = new ReceiptProductType()
                {
                    ReceiptId = data.RECEIPT_ID,
                    ProductTypeId = data.PRODUCT_TYPE_ID,
                    Quantity = data.QUANTITY
                };
            }
            return result;
        }
        public static RECEIPT_PRODUCT_TYPE ConvertToRECEIPT_PRODUCT_TYPE(ReceiptProductType data)
        {
            RECEIPT_PRODUCT_TYPE result = null;
            if (data != null)
            {
                result = new RECEIPT_PRODUCT_TYPE()
                {
                    RECEIPT_ID = data.ReceiptId,
                    PRODUCT_TYPE_ID = data.ProductTypeId,
                    QUANTITY = data.Quantity

                };
            }
            return result;
        }

        public static List<ReceiptProductType> ConvertToReceiptProductTypeList(List<RECEIPT_PRODUCT_TYPE> datas)
        {
            List<ReceiptProductType> result = new List<ReceiptProductType>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    ReceiptProductType rp = ConvertToReceiptProductType(data);
                    result.Add(rp);
                }
            }
            return result;
        }

        public static List<RECEIPT_PRODUCT_TYPE> ConvertToRECEIPT_PRODUCT_TYPEList(List<ReceiptProductType> datas)
        {
            List<RECEIPT_PRODUCT_TYPE> result = new List<RECEIPT_PRODUCT_TYPE>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    RECEIPT_PRODUCT_TYPE rp = ConvertToRECEIPT_PRODUCT_TYPE(data);
                    result.Add(rp);
                }
            }
            return result;
        }
    }
}
