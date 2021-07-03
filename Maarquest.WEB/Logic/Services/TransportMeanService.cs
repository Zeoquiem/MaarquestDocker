using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class TransportMeanService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public TransportMeanService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<TransportMean>> GetAll()
        {
            List<TransportMean> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<TransportMean>>("TransportMean/GetAll");

            return result;
        }

        public async Task<TransportMean> Get(int transportMeanId)
        {
            TransportMean result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<TransportMean>($"TransportMean/Get/{transportMeanId}");

            return result;
        }

        public async Task<TransportMean> Add(TransportMean transportMean)
        {
            TransportMean result = null;

            result = await _maarquestApiContext.HttpCreateAsync<TransportMean>("TransportMean/Add", transportMean);

            return result;
        }

        public async Task<TransportMean> Update(TransportMean transportMean)
        {
            TransportMean result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<TransportMean>("TransportMean/Update", transportMean);

            return result;
        }

        public async Task<int> Delete(int transportMeanid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"TransportMean/Delete?id={transportMeanid}");

            return result;
        }
    }
}
