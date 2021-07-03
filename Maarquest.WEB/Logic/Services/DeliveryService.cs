using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class DeliveryService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public DeliveryService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<Delivery>> GetAll()
        {
            List<Delivery> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<Delivery>>("Delivery/GetAll");

            return result;
        }

        public async Task<Delivery> Get(int deliveryId)
        {
            Delivery result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<Delivery>($"Delivery/Get/{deliveryId}");

            return result;
        }

        public async Task<Delivery> Add(Delivery delivery)
        {
            Delivery result = null;

            result = await _maarquestApiContext.HttpCreateAsync<Delivery>("Delivery/Add", delivery);

            return result;
        }

        public async Task<Delivery> Update(Delivery delivery)
        {
            Delivery result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<Delivery>("Delivery/Update", delivery);

            return result;
        }

        public async Task<int> Delete(int deliveryid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"Delivery/Delete?id={deliveryid}");

            return result;
        }
    }
}
