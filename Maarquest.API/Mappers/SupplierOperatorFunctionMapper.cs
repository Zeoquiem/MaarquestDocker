using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class SupplierOperatorFunctionMapper
    {
        public static SupplierOperatorFunction ConvertToSupplierOperatorFunction(SUPPLIER_OPERATOR_FUNCTION data)
        {
            SupplierOperatorFunction result = null;
            if (data != null)
            {
                result = new SupplierOperatorFunction()
                {
                    SupplierOperatorFunctionId = data.SUPPLIER_OPERATOR_FUNCTION_ID,
                    Label = data.LABEL,
                    Authorization = data.AUTHORIZATION
                };
            }
            return result;
        }
        public static SUPPLIER_OPERATOR_FUNCTION ConvertToSUPPLIER_OPERATOR_FUNCTION(SupplierOperatorFunction data)
        {
            SUPPLIER_OPERATOR_FUNCTION result = null;
            if (data != null)
            {
                result = new SUPPLIER_OPERATOR_FUNCTION()
                {
                    SUPPLIER_OPERATOR_FUNCTION_ID = data.SupplierOperatorFunctionId,
                    LABEL = data.Label,
                    AUTHORIZATION = data.Authorization

                };
            }
            return result;
        }

        public static List<SupplierOperatorFunction> ConvertToSupplierOperatorFunctionList(List<SUPPLIER_OPERATOR_FUNCTION> datas)
        {
            List<SupplierOperatorFunction> result = new List<SupplierOperatorFunction>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SupplierOperatorFunction sof = ConvertToSupplierOperatorFunction(data);
                    result.Add(sof);
                }
            }
            return result;
        }

        public static List<SUPPLIER_OPERATOR_FUNCTION> ConvertToSUPPLIER_OPERATOR_FUNCTIONList(List<SupplierOperatorFunction> datas)
        {
            List<SUPPLIER_OPERATOR_FUNCTION> result = new List<SUPPLIER_OPERATOR_FUNCTION>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SUPPLIER_OPERATOR_FUNCTION sof = ConvertToSUPPLIER_OPERATOR_FUNCTION(data);
                    result.Add(sof);
                }
            }
            return result;
        }
    }
}
