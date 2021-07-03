using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class PromotionService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public PromotionService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<Promotion>> GetAll()
        {
            List<Promotion> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<Promotion>>("Promotion/GetAll");

            return result;
        }

        public async Task<Promotion> Get(int promotionId)
        {
            Promotion result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<Promotion>($"Promotion/Get/{promotionId}");

            return result;
        }

        public async Task<Promotion> Add(Promotion promotion)
        {
            Promotion result = null;

            result = await _maarquestApiContext.HttpCreateAsync<Promotion>("Promotion/Add", promotion);

            return result;
        }

        public async Task<Promotion> Update(Promotion promotion)
        {
            Promotion result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<Promotion>("Promotion/Update", promotion);

            return result;
        }

        public async Task<int> Delete(int promotionid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"Promotion/Delete?id={promotionid}");

            return result;
        }
    }
}
