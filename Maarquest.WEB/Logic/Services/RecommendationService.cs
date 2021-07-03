using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class RecommendationService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public RecommendationService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<Recommendation>> GetAll()
        {
            List<Recommendation> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<Recommendation>>("Recommendation/GetAll");

            return result;
        }

        public async Task<Recommendation> Get(int recommendationId)
        {
            Recommendation result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<Recommendation>($"Recommendation/Get/{recommendationId}");

            return result;
        }

        public async Task<Recommendation> Add(Recommendation recommendation)
        {
            Recommendation result = null;

            result = await _maarquestApiContext.HttpCreateAsync<Recommendation>("Recommendation/Add", recommendation);

            return result;
        }

        public async Task<Recommendation> Update(Recommendation recommendation)
        {
            Recommendation result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<Recommendation>("Recommendation/Update", recommendation);

            return result;
        }

        public async Task<int> Delete(int recommendationid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"Recommendation/Delete?id={recommendationid}");

            return result;
        }
    }
}
