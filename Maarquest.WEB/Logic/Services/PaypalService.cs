using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class PaypalService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public PaypalService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<Paypal>> GetAll()
        {
            List<Paypal> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<Paypal>>("Paypal/GetAll");

            return result;
        }

        public async Task<Paypal> Get(int paypalId)
        {
            Paypal result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<Paypal>($"Paypal/Get/{paypalId}");

            return result;
        }

        public async Task<Paypal> Add(Paypal paypal)
        {
            Paypal result = null;

            result = await _maarquestApiContext.HttpCreateAsync<Paypal>("Paypal/Add", paypal);

            return result;
        }

        public async Task<Paypal> Update(Paypal paypal)
        {
            Paypal result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<Paypal>("Paypal/Update", paypal);

            return result;
        }

        public async Task<int> Delete(int paypalid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"Paypal/Delete?id={paypalid}");

            return result;
        }
    }
}
