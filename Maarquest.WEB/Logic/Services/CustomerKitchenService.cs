using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class CustomerKitchenService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public CustomerKitchenService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<CustomerKitchen>> GetAll()
        {
            List<CustomerKitchen> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<CustomerKitchen>>("CustomerKitchen/GetAll");

            return result;
        }

        public async Task<List<CustomerKitchen>> GetAllFromCustomer(int customerId)
        {
            List<CustomerKitchen> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<CustomerKitchen>>($"CustomerKitchen/GetAllFromCustomer/{customerId}");

            return result;
        }

        public async Task<List<CustomerKitchen>> GetAllFromProduct(int productId)
        {
            List<CustomerKitchen> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<CustomerKitchen>>($"CustomerKitchen/GetAllFromProduct/{productId}");

            return result;
        }

        public async Task<CustomerKitchen> Get(int customerId, int productId)
        {
            CustomerKitchen result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<CustomerKitchen>($"CustomerKitchen/Get?customerId={customerId}&productId={productId}");

            return result;
        }

        public async Task<CustomerKitchen> Add(CustomerKitchen customerKitchen)
        {
            CustomerKitchen result = null;

            result = await _maarquestApiContext.HttpCreateAsync<CustomerKitchen>("CustomerKitchen/Add", customerKitchen);

            return result;
        }

        public async Task<CustomerKitchen> UpdateCustomer(CustomerKitchen customerKitchen, int newCustomerId)
        {
            CustomerKitchen result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<CustomerKitchen>($"CustomerKitchen/UpdateCustomer?newCustomerId={newCustomerId}", customerKitchen);

            return result;
        }

        public async Task<CustomerKitchen> UpdateProduct(CustomerKitchen customerKitchen, int newProductId)
        {
            CustomerKitchen result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<CustomerKitchen>($"CustomerKitchen/UpdateProduct?newProductId={newProductId}", customerKitchen);

            return result;
        }

        public async Task<int> Delete(int customerId, int productId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"CustomerKitchen/Delete?customerId={customerId}&productId={productId}");

            return result;
        }

        public async Task<int> DeleteAllFromCustomer(int customerId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"CustomerKitchen/DeleteAllFromCustomer?customerId={customerId}");

            return result;
        }

        public async Task<int> DeleteAllFromProduct(int productId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"CustomerKitchen/DeleteAllFromProduct?productId={productId}");

            return result;
        }
    }
}
