using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class SupermarketStockService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public SupermarketStockService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<SupermarketStock>> GetAll()
        {
            List<SupermarketStock> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<SupermarketStock>>("SupermarketStock/GetAll");

            return result;
        }

        public async Task<SupermarketStock> Get(int supermarketStockId)
        {
            SupermarketStock result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<SupermarketStock>($"SupermarketStock/Get/{supermarketStockId}");

            return result;
        }

        public async Task<SupermarketStock> Add(SupermarketStock supermarketStock)
        {
            SupermarketStock result = null;

            result = await _maarquestApiContext.HttpCreateAsync<SupermarketStock>("SupermarketStock/Add", supermarketStock);

            return result;
        }

        public async Task<SupermarketStock> Update(SupermarketStock supermarketStock)
        {
            SupermarketStock result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<SupermarketStock>("SupermarketStock/Update", supermarketStock);

            return result;
        }

        public async Task<int> Delete(int supermarketStockid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"SupermarketStock/Delete?id={supermarketStockid}");

            return result;
        }
    }
}
