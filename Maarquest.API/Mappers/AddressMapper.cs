using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    public class AddressMapper
    {
        public static Address ConvertToAddress(ADDRESS data)
        {
            Address result = null;
            if (data != null)
            {
                result = new Address()
                {
                    AddressId = data.ADDRESS_ID,
                    Receiver = data.RECEIVER,
                    LignOne = data.LIGN_ONE,
                    LignTwo = data.LIGN_TWO,
                    PostCode = data.POSTCODE,
                    City = data.CITY,
                    Region = data.REGION,
                    Country = data.COUNTRY
                };
            }
            return result;
        }
        public static ADDRESS ConvertToADDRESS(Address data)
        {
            ADDRESS result = null;
            if (data != null)
            {
                result = new ADDRESS()
                {
                    ADDRESS_ID = data.AddressId,
                    RECEIVER = data.Receiver,
                    LIGN_ONE = data.LignOne,
                    LIGN_TWO = data.LignTwo,
                    POSTCODE = data.PostCode,
                    CITY = data.City,
                    REGION = data.Region,
                    COUNTRY = data.Country
                };
            }
            return result;
        }

        public static List<Address> ConvertToAddressList(List<ADDRESS> datas)
        {
            List<Address> result = new List<Address>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    Address a = ConvertToAddress(data);
                    result.Add(a);
                }
            }
            return result;
        }

        public static List<ADDRESS> ConvertToADDRESSList(List<Address> datas)
        {
            List<ADDRESS> result = new List<ADDRESS>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    ADDRESS a = ConvertToADDRESS(data);
                    result.Add(a);
                }
            }
            return result;
        }
    }
}
