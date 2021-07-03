using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class SupermarketShelfService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public SupermarketShelfService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<SupermarketShelf>> GetAll()
        {
            List<SupermarketShelf> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<SupermarketShelf>>("SupermarketShelf/GetAll");

            return result;
        }

        public async Task<SupermarketShelf> Get(int supermarketShelfId)
        {
            SupermarketShelf result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<SupermarketShelf>($"SupermarketShelf/Get/{supermarketShelfId}");

            return result;
        }

        public async Task<SupermarketShelf> Add(SupermarketShelf supermarketShelf)
        {
            SupermarketShelf result = null;

            result = await _maarquestApiContext.HttpCreateAsync<SupermarketShelf>("SupermarketShelf/Add", supermarketShelf);

            return result;
        }

        public async Task<SupermarketShelf> Update(SupermarketShelf supermarketShelf)
        {
            SupermarketShelf result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<SupermarketShelf>("SupermarketShelf/Update", supermarketShelf);

            return result;
        }

        public async Task<int> Delete(int supermarketShelfid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"SupermarketShelf/Delete?id={supermarketShelfid}");

            return result;
        }
    }
}
