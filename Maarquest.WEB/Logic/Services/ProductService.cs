using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class ProductService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public ProductService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<Product>> GetAll()
        {
            List<Product> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<Product>>("Product/GetAll");

            return result;
        }

        public async Task<Product> Get(int productId)
        {
            Product result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<Product>($"Product/Get/{productId}");

            return result;
        }

        public async Task<Product> Add(Product product)
        {
            Product result = null;

            result = await _maarquestApiContext.HttpCreateAsync<Product>("Product/Add", product);

            return result;
        }

        public async Task<Product> Update(Product product)
        {
            Product result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<Product>("Product/Update", product);

            return result;
        }

        public async Task<int> Delete(int productid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"Product/Delete?id={productid}");

            return result;
        }
    }
}
