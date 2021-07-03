using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class PromotionPackService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public PromotionPackService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<PromotionPack>> GetAll()
        {
            List<PromotionPack> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<PromotionPack>>("PromotionPack/GetAll");

            return result;
        }

        public async Task<PromotionPack> Get(int promotionPackId)
        {
            PromotionPack result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<PromotionPack>($"PromotionPack/Get/{promotionPackId}");

            return result;
        }

        public async Task<PromotionPack> Add(PromotionPack promotionPack)
        {
            PromotionPack result = null;

            result = await _maarquestApiContext.HttpCreateAsync<PromotionPack>("PromotionPack/Add", promotionPack);

            return result;
        }

        public async Task<PromotionPack> Update(PromotionPack promotionPack)
        {
            PromotionPack result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<PromotionPack>("PromotionPack/Update", promotionPack);

            return result;
        }

        public async Task<int> Delete(int promotionPackid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"PromotionPack/Delete?id={promotionPackid}");

            return result;
        }
    }
}
