using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class PromotionTypeService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public PromotionTypeService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<PromotionType>> GetAll()
        {
            List<PromotionType> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<PromotionType>>("PromotionType/GetAll");

            return result;
        }

        public async Task<PromotionType> Get(int promotionTypeId)
        {
            PromotionType result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<PromotionType>($"PromotionType/Get/{promotionTypeId}");

            return result;
        }

        public async Task<PromotionType> Add(PromotionType promotionType)
        {
            PromotionType result = null;

            result = await _maarquestApiContext.HttpCreateAsync<PromotionType>("PromotionType/Add", promotionType);

            return result;
        }

        public async Task<PromotionType> Update(PromotionType promotionType)
        {
            PromotionType result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<PromotionType>("PromotionType/Update", promotionType);

            return result;
        }

        public async Task<int> Delete(int promotionTypeid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"PromotionType/Delete?id={promotionTypeid}");

            return result;
        }
    }
}
