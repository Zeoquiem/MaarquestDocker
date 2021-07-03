using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class SupplierContactRequestMapper
    {
        public static SupplierContactRequest ConvertToSupplierContactRequest(SUPPLIER_CONTACT_REQUEST data)
        {
            SupplierContactRequest result = null;
            if (data != null)
            {
                result = new SupplierContactRequest()
                {
                    SupplierContactRequestId = data.SUPPLIER_CONTACT_REQUEST_ID,
                    SupplierId = data.SUPPLIER_ID,
                    IsTreated = data.IS_TREATED
                };
            }
            return result;
        }
        public static SUPPLIER_CONTACT_REQUEST ConvertToSUPPLIER_CONTACT_REQUEST(SupplierContactRequest data)
        {
            SUPPLIER_CONTACT_REQUEST result = null;
            if (data != null)
            {
                result = new SUPPLIER_CONTACT_REQUEST()
                {
                    SUPPLIER_CONTACT_REQUEST_ID = data.SupplierContactRequestId,
                    SUPPLIER_ID = data.SupplierId,
                    IS_TREATED = data.IsTreated

                };
            }
            return result;
        }

        public static List<SupplierContactRequest> ConvertToSupplierContactRequestList(List<SUPPLIER_CONTACT_REQUEST> datas)
        {
            List<SupplierContactRequest> result = new List<SupplierContactRequest>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SupplierContactRequest scr = ConvertToSupplierContactRequest(data);
                    result.Add(scr);
                }
            }
            return result;
        }

        public static List<SUPPLIER_CONTACT_REQUEST> ConvertToSUPPLIER_CONTACT_REQUESTList(List<SupplierContactRequest> datas)
        {
            List<SUPPLIER_CONTACT_REQUEST> result = new List<SUPPLIER_CONTACT_REQUEST>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SUPPLIER_CONTACT_REQUEST scr = ConvertToSUPPLIER_CONTACT_REQUEST(data);
                    result.Add(scr);
                }
            }
            return result;
        }
    }
}
