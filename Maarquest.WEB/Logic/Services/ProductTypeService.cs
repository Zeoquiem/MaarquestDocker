using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class ProductTypeService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public ProductTypeService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<ProductType>> GetAll()
        {
            List<ProductType> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<ProductType>>("ProductType/GetAll");

            return result;
        }

        public async Task<ProductType> Get(int productTypeId)
        {
            ProductType result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<ProductType>($"ProductType/Get/{productTypeId}");

            return result;
        }

        public async Task<ProductType> Add(ProductType productType)
        {
            ProductType result = null;

            result = await _maarquestApiContext.HttpCreateAsync<ProductType>("ProductType/Add", productType);

            return result;
        }

        public async Task<ProductType> Update(ProductType productType)
        {
            ProductType result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<ProductType>("ProductType/Update", productType);

            return result;
        }

        public async Task<int> Delete(int productTypeid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"ProductType/Delete?id={productTypeid}");

            return result;
        }
    }
}
