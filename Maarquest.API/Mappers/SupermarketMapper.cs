using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;


namespace Maarquest.API.Mappers
{
    class SupermarketMapper
    {
        public static Supermarket ConvertToSupermarket(SUPERMARKET data)
        {
            Supermarket result = null;
            if (data != null)
            {
                result = new Supermarket()
                {
                    SupermarketId = data.SUPERMARKET_ID,
                    AddressId = data.ADDRESS_ID,
                    Tel= data.TEL,
                    Fax = data.FAX
                };
            }
            return result;
        }
        public static SUPERMARKET ConvertToSUPERMARKET(Supermarket data)
        {
            SUPERMARKET result = null;
            if (data != null)
            {
                result = new SUPERMARKET()
                {
                    SUPERMARKET_ID = data.SupermarketId,
                    ADDRESS_ID = data.AddressId,
                    TEL = data.Tel,
                    FAX = data.Fax

                };
            }
            return result;
        }

        public static List<Supermarket> ConvertToSupermarketList(List<SUPERMARKET> datas)
        {
            List<Supermarket> result = new List<Supermarket>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    Supermarket s = ConvertToSupermarket(data);
                    result.Add(s);
                }
            }
            return result;
        }

        public static List<SUPERMARKET> ConvertToSUPERMARKETList(List<Supermarket> datas)
        {
            List<SUPERMARKET> result = new List<SUPERMARKET>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    SUPERMARKET s = ConvertToSUPERMARKET(data);
                    result.Add(s);
                }
            }
            return result;
        }
    }
}
