using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maarquest.API.Data;
using Maarquest.API.Models;


namespace Maarquest.API.Mappers
{
    class CustomerKitchenMapper
    {
        public static CustomerKitchen ConvertToCustomerKitchen(CUSTOMER_KITCHEN data)
        {
            CustomerKitchen result = null;
            if (data != null)
            {
                result = new CustomerKitchen()
                {
                    CustomerId = data.CUSTOMER_ID,
                    ProductId = data.PRODUCT_ID
                };
                    
            }
            return result;
        }
        public static CUSTOMER_KITCHEN ConvertToCUSTOMER_KITCHEN(CustomerKitchen data)
        {
            CUSTOMER_KITCHEN result = null;
            if (data != null)
            {
                result = new CUSTOMER_KITCHEN()
                {
                    CUSTOMER_ID = data.CustomerId,
                    PRODUCT_ID = data.ProductId

                };
            }
            return result;
        }

        public static List<CustomerKitchen> ConvertToCustomerKitchenList(List<CUSTOMER_KITCHEN> datas)
        {
            List<CustomerKitchen> result = new List<CustomerKitchen>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    CustomerKitchen ck = ConvertToCustomerKitchen(data);
                    result.Add(ck);
                }
            }
            return result;
        }

        public static List<CUSTOMER_KITCHEN> ConvertToCUSTOMERList(List<CustomerKitchen> datas)
        {
            List<CUSTOMER_KITCHEN> result = new List<CUSTOMER_KITCHEN>();

            if (datas != null)
            {
                foreach (var data in datas)
                {
                    CUSTOMER_KITCHEN ck = ConvertToCUSTOMER_KITCHEN(data);
                    result.Add(ck);
                }
            }
            return result;
        }
    }
}
