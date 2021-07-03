using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class PaymentMeanMapper
    {
        public static PaymentMean ConvertToPaymentMean(PAYMENT_MEAN data)
        {
            PaymentMean result = null;
            if (data != null)
            {
                result = new PaymentMean()
                {
                    PaymentMeanId = data.PAYMENT_MEAN_ID,
                    UserId = data.USER_ID,
                    UserTypeId = data.USER_TYPE_ID,
                    AddressId = data.ADDRESS_ID,
                    PaymentId= data.PAYMENT_ID, 
                    PaymentTypeId = data.PAYMENT_TYPE_ID,
                    IsDefault = data.IS_DEFAULT
                };
            }
            return result;
        }
        public static PAYMENT_MEAN ConvertToPAYMENT_MEAN(PaymentMean data)
        {
            PAYMENT_MEAN result = null;
            if (data != null)
            {
                result = new PAYMENT_MEAN()
                {
                    PAYMENT_MEAN_ID = data.PaymentMeanId,
                    USER_ID = data.UserId,
                    USER_TYPE_ID = data.UserTypeId,
                    ADDRESS_ID = data.AddressId,
                    PAYMENT_ID = data.PaymentId, 
                    PAYMENT_TYPE_ID = data.PaymentTypeId,
                    IS_DEFAULT = data.IsDefault

                };
            }
            return result;
        }

        public static List<PaymentMean> ConvertToPaymentMeanList(List<PAYMENT_MEAN> datas)
        {
            List<PaymentMean> result = new List<PaymentMean>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PaymentMean p = ConvertToPaymentMean(data);
                    result.Add(p);
                }
            }
            return result;
        }

        public static List<PAYMENT_MEAN> ConvertToPAYMENT_MEANList(List<PaymentMean> datas)
        {
            List<PAYMENT_MEAN> result = new List<PAYMENT_MEAN>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PAYMENT_MEAN p = ConvertToPAYMENT_MEAN(data);
                    result.Add(p);
                }
            }
            return result;
        }
    }
}
