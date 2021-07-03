using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class SupplierMapper
    {
        public static Supplier ConvertToSupplier(SUPPLIER data)
        {
            Supplier result = null;
            if (data != null)
            {
                result = new Supplier()
                {
                    SupplierId = data.SUPPLIER_ID,
                    AddressId = data.ADDRESS_ID,
                    CompanyName = data.COMPANY_NAME,
                    CompanySign = data.COMPANY_SIGN,
                    Siret = data.SIRET,
                    Tel = data.TEL,
                    Fax = data.FAX,
                    IsReady = data.IS_READY
                };
            }
            return result;
        }
        public static SUPPLIER ConvertToSUPPLIER(Supplier data)
        {
            SUPPLIER result = null;
            if (data != null)
            {
                result = new SUPPLIER()
                {
                    SUPPLIER_ID = data.SupplierId,
                    ADDRESS_ID = data.AddressId,
                    COMPANY_NAME = data.CompanyName,
                    COMPANY_SIGN= data.CompanySign,
                    SIRET = data.Siret,
                    TEL = data.Tel,
                    FAX = data.Fax,
                    IS_READY = data.IsReady

                };
            }
            return result;
        }

        public static List<Supplier> ConvertToSupplierList(List<SUPPLIER> datas)
        {
            List<Supplier> result = new List<Supplier>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    Supplier s = ConvertToSupplier(data);
                    result.Add(s);
                }
            }
            return result;
        }

        public static List<SUPPLIER> ConvertToSUPPLIERList(List<Supplier> datas)
        {
            List<SUPPLIER> result = new List<SUPPLIER>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SUPPLIER s = ConvertToSUPPLIER(data);
                    result.Add(s);
                }
            }
            return result;
        }
    }
}
