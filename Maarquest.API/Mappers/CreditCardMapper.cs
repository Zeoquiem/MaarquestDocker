using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    public class CreditCardMapper
    {
        public static CreditCard ConvertToCreditCard(CREDIT_CARD data)
        {
            CreditCard result = null;
            if (data != null)
            {
                result = new CreditCard()
                {
                    CreditCardId = data.CREDIT_CARD_ID,
                    CardNumber = data.CARD_NUMBER,
                    CardName = data.CARD_NAME,
                    ExpiryDate = data.EXPIRY_DATE,
                    SecurityCode = data.SECURITY_CODE
                };
            }
            return result;
        }
        public static CREDIT_CARD ConvertToCREDIT_CARD(CreditCard data)
        {
            CREDIT_CARD result = null;
            if (data != null)
            {
                result = new CREDIT_CARD()
                {
                    CREDIT_CARD_ID = data.CreditCardId,
                    CARD_NUMBER = data.CardNumber,
                    CARD_NAME = data.CardName,
                    EXPIRY_DATE = data.ExpiryDate,
                    SECURITY_CODE = data.SecurityCode
                };
            }
            return result;
        }

        public static List<CreditCard> ConvertToCreditCardList(List<CREDIT_CARD> datas)
        {
            List<CreditCard> result = new List<CreditCard>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    CreditCard cc = ConvertToCreditCard(data);
                    result.Add(cc);
                }
            }
            return result;
        }

        public static List<CREDIT_CARD> ConvertToCREDIT_CARDList(List<CreditCard> datas)
        {
            List<CREDIT_CARD> result = new List<CREDIT_CARD>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    CREDIT_CARD cc = ConvertToCREDIT_CARD(data);
                    result.Add(cc);
                }
            }
            return result;
        }
    }
}
