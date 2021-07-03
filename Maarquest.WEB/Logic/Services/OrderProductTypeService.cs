using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class OrderProductTypeService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public OrderProductTypeService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<OrderProductType>> GetAll()
        {
            List<OrderProductType> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<OrderProductType>>("OrderProductType/GetAll");

            return result;
        }

        public async Task<List<OrderProductType>> GetAllFromOrder(int orderId)
        {
            List<OrderProductType> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<OrderProductType>>($"OrderProductType/GetAllFromOrder/{orderId}");

            return result;
        }

        public async Task<List<OrderProductType>> GetAllFromProductType(int productTypeId)
        {
            List<OrderProductType> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<OrderProductType>>($"OrderProductType/GetAllFromProduct/{productTypeId}");

            return result;
        }

        public async Task<OrderProductType> Get(int orderId, int productTypeId)
        {
            OrderProductType result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<OrderProductType>($"OrderProductType/Get?orderId={orderId}&productTypeId={productTypeId}");

            return result;
        }

        public async Task<OrderProductType> Add(OrderProductType orderProductType)
        {
            OrderProductType result = null;

            result = await _maarquestApiContext.HttpCreateAsync<OrderProductType>("OrderProductType/Add", orderProductType);

            return result;
        }

        public async Task<OrderProductType> UpdateOrder(OrderProductType orderProductType, int newOrderId)
        {
            OrderProductType result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<OrderProductType>($"OrderProductType/UpdateOrder?newOrderId={newOrderId}", orderProductType);

            return result;
        }

        public async Task<OrderProductType> UpdateProductType(OrderProductType orderProductType, int newProductTypeId)
        {
            OrderProductType result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<OrderProductType>($"OrderProductType/UpdateProduct?newProductTypeId={newProductTypeId}", orderProductType);

            return result;
        }

        public async Task<int> Delete(int orderId, int productTypeId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"OrderProductType/Delete?orderId={orderId}&productTypeId={productTypeId}");

            return result;
        }

        public async Task<int> DeleteAllFromOrder(int orderId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"OrderProductType/DeleteAllFromOrder?orderId={orderId}");

            return result;
        }

        public async Task<int> DeleteAllFromProductType(int productTypeId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"OrderProductType/DeleteAllFromProduct?productTypeId={productTypeId}");

            return result;
        }
    }
}
