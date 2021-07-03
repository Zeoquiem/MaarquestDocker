using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class SupermarketOperatorService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public SupermarketOperatorService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<SupermarketOperator>> GetAll()
        {
            List<SupermarketOperator> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<SupermarketOperator>>("SupermarketOperator/GetAll");

            return result;
        }

        public async Task<SupermarketOperator> Get(int supermarketOperatorId)
        {
            SupermarketOperator result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<SupermarketOperator>($"SupermarketOperator/Get/{supermarketOperatorId}");

            return result;
        }

        public async Task<SupermarketOperator> Add(SupermarketOperator supermarketOperator)
        {
            SupermarketOperator result = null;

            result = await _maarquestApiContext.HttpCreateAsync<SupermarketOperator>("SupermarketOperator/Add", supermarketOperator);

            return result;
        }

        public async Task<SupermarketOperator> Update(SupermarketOperator supermarketOperator)
        {
            SupermarketOperator result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<SupermarketOperator>("SupermarketOperator/Update", supermarketOperator);

            return result;
        }

        public async Task<int> Delete(int supermarketOperatorid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"SupermarketOperator/Delete?id={supermarketOperatorid}");

            return result;
        }
    }
}
