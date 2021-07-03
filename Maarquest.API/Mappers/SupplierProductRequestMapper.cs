using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class SupplierProductRequestMapper
    {
        public static SupplierProductRequest ConvertToSupplierProductRequest(SUPPLIER_PRODUCT_REQUEST data)
        {
            SupplierProductRequest result = null;
            if (data != null)
            {
                result = new SupplierProductRequest()
                {
                    SupplierProductRequestId = data.SUPPLIER_PRODUCT_REQUEST_ID,
                    SupplierId = data.SUPPLIER_ID,
                    ProductTypeId = data.PRODUCT_TYPE_ID,
                    IsTreated = data.IS_TREATED
                };
            }
            return result;
        }
        public static SUPPLIER_PRODUCT_REQUEST ConvertToSUPPLIER_PRODUCT_REQUEST(SupplierProductRequest data)
        {
            SUPPLIER_PRODUCT_REQUEST result = null;
            if (data != null)
            {
                result = new SUPPLIER_PRODUCT_REQUEST()
                {
                    SUPPLIER_PRODUCT_REQUEST_ID = data.SupplierProductRequestId,
                    SUPPLIER_ID = data.SupplierId,
                    PRODUCT_TYPE_ID= data.ProductTypeId,
                    IS_TREATED= data.IsTreated

                };
            }
            return result;
        }

        public static List<SupplierProductRequest> ConvertToSupplierProductRequestList(List<SUPPLIER_PRODUCT_REQUEST> datas)
        {
            List<SupplierProductRequest> result = new List<SupplierProductRequest>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SupplierProductRequest spr = ConvertToSupplierProductRequest(data);
                    result.Add(spr);
                }
            }
            return result;
        }

        public static List<SUPPLIER_PRODUCT_REQUEST> ConvertToSUPPLIER_PRODUCT_REQUESTList(List<SupplierProductRequest> datas)
        {
            List<SUPPLIER_PRODUCT_REQUEST> result = new List<SUPPLIER_PRODUCT_REQUEST>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SUPPLIER_PRODUCT_REQUEST spr = ConvertToSUPPLIER_PRODUCT_REQUEST(data);
                    result.Add(spr);
                }
            }
            return result;
        }
    }
}
