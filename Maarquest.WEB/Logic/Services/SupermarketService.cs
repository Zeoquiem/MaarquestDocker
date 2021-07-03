using SupermarketModel = Maarquest.WEB.Logic.Models.Supermarket;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class SupermarketService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public SupermarketService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<SupermarketModel>> GetAll()
        {
            List<SupermarketModel> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<SupermarketModel>>("Supermarket/GetAll");

            return result;
        }

        public async Task<SupermarketModel> Get(int supermarketId)
        {
            SupermarketModel result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<SupermarketModel>($"Supermarket/Get/{supermarketId}");

            return result;
        }

        public async Task<SupermarketModel> Add(SupermarketModel supermarket)
        {
            SupermarketModel result = null;

            result = await _maarquestApiContext.HttpCreateAsync<SupermarketModel>("Supermarket/Add", supermarket);

            return result;
        }

        public async Task<SupermarketModel> Update(SupermarketModel supermarket)
        {
            SupermarketModel result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<SupermarketModel>("Supermarket/Update", supermarket);

            return result;
        }

        public async Task<int> Delete(int supermarketid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"Supermarket/Delete?id={supermarketid}");

            return result;
        }
    }
}
