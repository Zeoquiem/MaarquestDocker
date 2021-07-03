using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;

namespace Maarquest.API.Mappers
{
    class CustomerMapper
    {
        public static Customer ConvertToCustomer(CUSTOMER data)
        {
            Customer result = null;
            if (data != null)
            {
                result = new Customer()
                {
                    CustomerId = data.CUSTOMER_ID,
                    AddressId = data.ADDRESS_ID,
                    FirstName = data.FIRSTNAME,
                    LastName = data.LASTNAME,
                    UserName = data.USERNAME,
                   Mail = data.MAIL,
                    Password = data.PASSWORD,
                   Birthdate = data.BIRTHDATE,
                    Gender = data.GENDER,
                    Tel = data.TEL
                };
            }
            return result;
        }
        public static CUSTOMER ConvertToCUSTOMER(Customer data)
        {
            CUSTOMER result = null;
            if (data != null)
            {
                result = new CUSTOMER()
                {
                    CUSTOMER_ID = data.CustomerId,
                   ADDRESS_ID = data.AddressId,
                    FIRSTNAME = data.FirstName,
                    LASTNAME = data.LastName,
                    USERNAME = data.UserName,
                    MAIL = data.Mail,
                    PASSWORD = data.Password,
                    BIRTHDATE = data.Birthdate,
                    GENDER = data.Gender,
                    TEL = data.Tel

                };
            }
            return result;
        }

        public static List<Customer> ConvertToCustomerList(List<CUSTOMER> datas)
        {
            List<Customer> result = new List<Customer>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    Customer c = ConvertToCustomer(data);
                    result.Add(c);
                }
            }
            return result;
        }

        public static List<CUSTOMER> ConvertToCUSTOMERList(List<Customer> datas)
        {
            List<CUSTOMER> result = new List<CUSTOMER>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    CUSTOMER c = ConvertToCUSTOMER(data);
                    result.Add(c);
                }
            }
            return result;
        }
    }
}
