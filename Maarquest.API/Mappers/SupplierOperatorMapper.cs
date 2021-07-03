using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class SupplierOperatorMapper
    {
        public static SupplierOperator ConvertToSupplierOperator(SUPPLIER_OPERATOR data)
        {
            SupplierOperator result = null;
            if (data != null)
            {
                result = new SupplierOperator()
                {
                    SupplierOperatorId = data.SUPPLIER_OPERATOR_ID,
                    SupplierId = data.SUPPLIER_ID,
                    SupplierOperatorFunctionId = data.SUPPLIER_OPERATOR_FUNCTION_ID,
                    Firstname = data.FIRSTNAME,
                    Lastname = data.LASTNAME,
                    Username = data.USERNAME,
                    Mail = data.MAIL,
                    Password = data.PASSWORD,
                    Birthdate = data.BIRTHDATE,
                    Gender = data.GENDER,
                    Tel = data.TEL
                };
            }
            return result;
        }
        public static SUPPLIER_OPERATOR ConvertToSUPPLIER_OPERATOR(SupplierOperator data)
        {
            SUPPLIER_OPERATOR result = null;
            if (data != null)
            {
                result = new SUPPLIER_OPERATOR()
                {
                    SUPPLIER_OPERATOR_ID = data.SupplierOperatorId,
                    SUPPLIER_ID = data.SupplierId,
                    SUPPLIER_OPERATOR_FUNCTION_ID = data.SupplierOperatorFunctionId,
                    FIRSTNAME = data.Firstname,
                    LASTNAME = data.Lastname,
                    USERNAME = data.Username,
                    MAIL = data.Mail,
                    PASSWORD = data.Password,
                    BIRTHDATE = data.Birthdate,
                    GENDER = data.Gender,
                    TEL = data.Tel

                };
            }
            return result;
        }

        public static List<SupplierOperator> ConvertToSupplierOperatorList(List<SUPPLIER_OPERATOR> datas)
        {
            List<SupplierOperator> result = new List<SupplierOperator>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SupplierOperator so = ConvertToSupplierOperator(data);
                    result.Add(so);
                }
            }
            return result;
        }

        public static List<SUPPLIER_OPERATOR> ConvertToSUPPLIER_OPERATORList(List<SupplierOperator> datas)
        {
            List<SUPPLIER_OPERATOR> result = new List<SUPPLIER_OPERATOR>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SUPPLIER_OPERATOR so = ConvertToSUPPLIER_OPERATOR(data);
                    result.Add(so);
                }
            }
            return result;
        }
    }
}
