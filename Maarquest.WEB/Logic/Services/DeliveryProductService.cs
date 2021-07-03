using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class DeliveryProductService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public DeliveryProductService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<DeliveryProduct>> GetAll()
        {
            List<DeliveryProduct> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<DeliveryProduct>>("DeliveryProduct/GetAll");

            return result;
        }

        public async Task<List<DeliveryProduct>> GetAllFromDelivery(int deliveryId)
        {
            List<DeliveryProduct> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<DeliveryProduct>>($"DeliveryProduct/GetAllFromDelivery/{deliveryId}");

            return result;
        }

        public async Task<List<DeliveryProduct>> GetAllFromProduct(int productId)
        {
            List<DeliveryProduct> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<DeliveryProduct>>($"DeliveryProduct/GetAllFromProduct/{productId}");

            return result;
        }

        public async Task<DeliveryProduct> Get(int deliveryId, int productId)
        {
            DeliveryProduct result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<DeliveryProduct>($"DeliveryProduct/Get?deliveryId={deliveryId}&productId={productId}");

            return result;
        }

        public async Task<DeliveryProduct> Add(DeliveryProduct deliveryProduct)
        {
            DeliveryProduct result = null;

            result = await _maarquestApiContext.HttpCreateAsync<DeliveryProduct>("DeliveryProduct/Add", deliveryProduct);

            return result;
        }

        public async Task<DeliveryProduct> UpdateDelivery(DeliveryProduct deliveryProduct, int newDeliveryId)
        {
            DeliveryProduct result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<DeliveryProduct>($"DeliveryProduct/UpdateDelivery?newDeliveryId={newDeliveryId}", deliveryProduct);

            return result;
        }

        public async Task<DeliveryProduct> UpdateProduct(DeliveryProduct deliveryProduct, int newProductId)
        {
            DeliveryProduct result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<DeliveryProduct>($"DeliveryProduct/UpdateProduct?newProductId={newProductId}", deliveryProduct);

            return result;
        }

        public async Task<int> Delete(int deliveryId, int productId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"DeliveryProduct/Delete?deliveryId={deliveryId}&productId={productId}");

            return result;
        }

        public async Task<int> DeleteAllFromDelivery(int deliveryId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"DeliveryProduct/DeleteAllFromDelivery?deliveryId={deliveryId}");

            return result;
        }

        public async Task<int> DeleteAllFromProduct(int productId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"DeliveryProduct/DeleteAllFromProduct?productId={productId}");

            return result;
        }
    }
}
