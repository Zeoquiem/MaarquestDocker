using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class SupermarketOperatorFunctionMapper
    {
        public static SupermarketOperatorFunction ConvertToSupermarketOperatorFunction(SUPERMARKET_OPERATOR_FUNCTION data)
        {
            SupermarketOperatorFunction result = null;
            if (data != null)
            {
                result = new SupermarketOperatorFunction()
                {
                    SupermarketOperatorFunctionId = data.SUPERMARKET_OPERATOR_FUNCTION_ID,
                    Label = data.LABEL,
                    Authorization = data.AUTHORIZATION
                };
            }
            return result;
        }
        public static SUPERMARKET_OPERATOR_FUNCTION ConvertToSUPERMARKET_OPERATOR_FUNCTION(SupermarketOperatorFunction data)
        {
            SUPERMARKET_OPERATOR_FUNCTION result = null;
            if (data != null)
            {
                result = new SUPERMARKET_OPERATOR_FUNCTION()
                {
                    SUPERMARKET_OPERATOR_FUNCTION_ID= data.SupermarketOperatorFunctionId,
                    LABEL = data.Label,
                    AUTHORIZATION = data.Authorization

                };
            }
            return result;
        }

        public static List<SupermarketOperatorFunction> ConvertToSupermarketOperatorFunctionList(List<SUPERMARKET_OPERATOR_FUNCTION> datas)
        {
            List<SupermarketOperatorFunction> result = new List<SupermarketOperatorFunction>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SupermarketOperatorFunction sof = ConvertToSupermarketOperatorFunction(data);
                    result.Add(sof);
                }
            }
            return result;
        }

        public static List<SUPERMARKET_OPERATOR_FUNCTION> ConvertToSUPERMARKET_OPERATOR_FUNCTIONList(List<SupermarketOperatorFunction> datas)
        {
            List<SUPERMARKET_OPERATOR_FUNCTION> result = new List<SUPERMARKET_OPERATOR_FUNCTION>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SUPERMARKET_OPERATOR_FUNCTION sof = ConvertToSUPERMARKET_OPERATOR_FUNCTION(data);
                    result.Add(sof);
                }
            }
            return result;
        }
    }
}
