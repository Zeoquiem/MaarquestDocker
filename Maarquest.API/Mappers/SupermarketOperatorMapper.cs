using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class SupermarketOperatorMapper
    {
            public static SupermarketOperator ConvertToSupermarketOperator(SUPERMARKET_OPERATOR data)
            {
                SupermarketOperator result = null;
                if (data != null)
                {
                    result = new SupermarketOperator()
                    {
                        SupermarketOperatorId = data.SUPERMARKET_OPERATOR_ID,
                        SupermarketId = data.SUPERMARKET_ID,
                        SupermarketOperatorFunctionId = data.SUPERMARKET_OPERATOR_FUNCTION_ID,
                        Firstname = data.FIRSTNAME,
                        Lastname = data.LASTNAME,
                        Username= data.USERNAME,
                        Mail = data.MAIL,
                        Password = data.PASSWORD,
                        Birthdate = data.BIRTHDATE,
                        Gender = data.GENDER,
                        Tel = data.TEL
                    };
                }
                return result;
            }
            public static SUPERMARKET_OPERATOR ConvertToSUPERMARKET_OPERATOR(SupermarketOperator data)
            {
                SUPERMARKET_OPERATOR result = null;
                if (data != null)
                {
                    result = new SUPERMARKET_OPERATOR()
                    {
                        SUPERMARKET_OPERATOR_ID = data.SupermarketOperatorId,
                        SUPERMARKET_ID = data.SupermarketId,
                        SUPERMARKET_OPERATOR_FUNCTION_ID = data.SupermarketOperatorFunctionId,
                        FIRSTNAME = data.Firstname,
                        LASTNAME = data.Lastname,
                        USERNAME = data.Username,
                        MAIL = data.Mail,
                        PASSWORD = data.Password,
                        BIRTHDATE= data.Birthdate,
                        GENDER = data.Gender,
                        TEL = data.Tel

                    };
                }
                return result;
            }

            public static List<SupermarketOperator> ConvertToSupermarketOperatorList(List<SUPERMARKET_OPERATOR> datas)
            {
                List<SupermarketOperator> result = new List<SupermarketOperator>();

                if (datas != null)
                {
                    foreach (var data in datas)
                    {
                        SupermarketOperator so = ConvertToSupermarketOperator(data);
                        result.Add(so);
                    }
                }
                return result;
            }

            public static List<SUPERMARKET_OPERATOR> ConvertToSUPERMARKET_OPERATORList(List<SupermarketOperator> datas)
            {
                List<SUPERMARKET_OPERATOR> result = new List<SUPERMARKET_OPERATOR>();

                if (datas != null)
                {
                    foreach (var data in datas)
                    {
                        SUPERMARKET_OPERATOR so = ConvertToSUPERMARKET_OPERATOR(data);
                        result.Add(so);
                    }
                }
                return result;
            }

     }
}
