using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;


namespace Maarquest.API.Mappers
{
    class PaypalMapper
    {
        public static Paypal ConvertToPaypal(PAYPAL data)
        {
            Paypal result = null;
            if (data != null)
            {
                result = new Paypal()
                {
                    PaypalId = data.PAYPAL_ID,
                    IsConnected = data.IS_CONNECTED,
                    IdentifiantPaypal = data.IDENTIFIANT_PAYPAL
                };
            }
            return result;
        }
        public static PAYPAL ConvertToPAYPAL(Paypal data)
        {
            PAYPAL result = null;
            if (data != null)
            {
                result = new PAYPAL()
                {
                    PAYPAL_ID = data.PaypalId,
                    IS_CONNECTED = data.IsConnected,
                    IDENTIFIANT_PAYPAL = data.IdentifiantPaypal

                };
            }
            return result;
        }

        public static List<Paypal> ConvertToPaypalList(List<PAYPAL> datas)
        {
            List<Paypal> result = new List<Paypal>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    Paypal p = ConvertToPaypal(data);
                    result.Add(p);
                }
            }
            return result;
        }

        public static List<PAYPAL> ConvertToPAYPALList(List<Paypal> datas)
        {
            List<PAYPAL> result = new List<PAYPAL> ();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    PAYPAL p = ConvertToPAYPAL(data);
                    result.Add(p);
                }
            }
            return result;
        }
    }
}
