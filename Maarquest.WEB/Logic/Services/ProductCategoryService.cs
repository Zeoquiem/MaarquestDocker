using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class ProductCategoryService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public ProductCategoryService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<ProductCategory>> GetAll()
        {
            List<ProductCategory> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<ProductCategory>>("ProductCategory/GetAll");

            return result;
        }

        public async Task<ProductCategory> Get(int productCategoryId)
        {
            ProductCategory result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<ProductCategory>($"ProductCategory/Get/{productCategoryId}");

            return result;
        }

        public async Task<ProductCategory> Add(ProductCategory productCategory)
        {
            ProductCategory result = null;

            result = await _maarquestApiContext.HttpCreateAsync<ProductCategory>("ProductCategory/Add", productCategory);

            return result;
        }

        public async Task<ProductCategory> Update(ProductCategory productCategory)
        {
            ProductCategory result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<ProductCategory>("ProductCategory/Update", productCategory);

            return result;
        }

        public async Task<int> Delete(int productCategoryid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"ProductCategory/Delete?id={productCategoryid}");

            return result;
        }
    }
}
