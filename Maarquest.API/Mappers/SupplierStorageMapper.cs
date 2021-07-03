using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class SupplierStorageMapper
    {
        public static SupplierStorage ConvertToSupplierStorage(SUPPLIER_STORAGE data)
        {
            SupplierStorage result = null;
            if (data != null)
            {
                result = new SupplierStorage()
                {
                    SupplierStorageId = data.SUPPLIER_STORAGE_ID,
                    SupplierId = data.SUPPLIER_ID,
                    AddressId = data.ADDRESS_ID
                };
            }
            return result;
        }
        public static SUPPLIER_STORAGE ConvertToSUPPLIER_STORAGE(SupplierStorage data)
        {
            SUPPLIER_STORAGE result = null;
            if (data != null)
            {
                result = new SUPPLIER_STORAGE()
                {
                    SUPPLIER_STORAGE_ID = data.SupplierStorageId,
                    SUPPLIER_ID = data.SupplierId,
                    ADDRESS_ID = data.AddressId

                };
            }
            return result;
        }

        public static List<SupplierStorage> ConvertToSupplierStorageList(List<SUPPLIER_STORAGE> datas)
        {
            List<SupplierStorage> result = new List<SupplierStorage>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SupplierStorage ss = ConvertToSupplierStorage(data);
                    result.Add(ss);
                }
            }
            return result;
        }

        public static List<SUPPLIER_STORAGE> ConvertToDELIVERYList(List<SupplierStorage> datas)
        {
            List<SUPPLIER_STORAGE> result = new List<SUPPLIER_STORAGE>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SUPPLIER_STORAGE ss = ConvertToSUPPLIER_STORAGE(data);
                    result.Add(ss);
                }
            }
            return result;
        }
    }
}
