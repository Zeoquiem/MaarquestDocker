using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class OrderService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public OrderService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<Order>> GetAll()
        {
            List<Order> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<Order>>("Order/GetAll");

            return result;
        }

        public async Task<Order> Get(int orderId)
        {
            Order result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<Order>($"Order/Get/{orderId}");

            return result;
        }

        public async Task<Order> Add(Order order)
        {
            Order result = null;

            result = await _maarquestApiContext.HttpCreateAsync<Order>("Order/Add", order);

            return result;
        }

        public async Task<Order> Update(Order order)
        {
            Order result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<Order>("Order/Update", order);

            return result;
        }

        public async Task<int> Delete(int orderid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"Order/Delete?id={orderid}");

            return result;
        }
    }
}
