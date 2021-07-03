using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class SupermarketOperatorFunctionService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public SupermarketOperatorFunctionService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<SupermarketOperatorFunction>> GetAll()
        {
            List<SupermarketOperatorFunction> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<SupermarketOperatorFunction>>("SupermarketOperatorFunction/GetAll");

            return result;
        }

        public async Task<SupermarketOperatorFunction> Get(int supermarketOperatorFunctionId)
        {
            SupermarketOperatorFunction result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<SupermarketOperatorFunction>($"SupermarketOperatorFunction/Get/{supermarketOperatorFunctionId}");

            return result;
        }

        public async Task<SupermarketOperatorFunction> Add(SupermarketOperatorFunction supermarketOperatorFunction)
        {
            SupermarketOperatorFunction result = null;

            result = await _maarquestApiContext.HttpCreateAsync<SupermarketOperatorFunction>("SupermarketOperatorFunction/Add", supermarketOperatorFunction);

            return result;
        }

        public async Task<SupermarketOperatorFunction> Update(SupermarketOperatorFunction supermarketOperatorFunction)
        {
            SupermarketOperatorFunction result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<SupermarketOperatorFunction>("SupermarketOperatorFunction/Update", supermarketOperatorFunction);

            return result;
        }

        public async Task<int> Delete(int supermarketOperatorFunctionid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"SupermarketOperatorFunction/Delete?id={supermarketOperatorFunctionid}");

            return result;
        }
    }
}
