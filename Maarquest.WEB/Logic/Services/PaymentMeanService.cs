using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class PaymentMeanService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public PaymentMeanService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<PaymentMean>> GetAll()
        {
            List<PaymentMean> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<PaymentMean>>("PaymentMean/GetAll");

            return result;
        }

        public async Task<PaymentMean> Get(int paymentMeanId)
        {
            PaymentMean result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<PaymentMean>($"PaymentMean/Get/{paymentMeanId}");

            return result;
        }

        public async Task<PaymentMean> Add(PaymentMean paymentMean)
        {
            PaymentMean result = null;

            result = await _maarquestApiContext.HttpCreateAsync<PaymentMean>("PaymentMean/Add", paymentMean);

            return result;
        }

        public async Task<PaymentMean> Update(PaymentMean paymentMean)
        {
            PaymentMean result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<PaymentMean>("PaymentMean/Update", paymentMean);

            return result;
        }

        public async Task<int> Delete(int paymentMeanid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"PaymentMean/Delete?id={paymentMeanid}");

            return result;
        }
    }
}
