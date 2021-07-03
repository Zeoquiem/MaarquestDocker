using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class CreditCardService 
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public CreditCardService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<CreditCard>> GetAll()
        {
            List<CreditCard> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<CreditCard>>("CreditCard/GetAll");

            return result;
        }

        public async Task<CreditCard> Get(int creditCardId)
        {
            CreditCard result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<CreditCard>($"CreditCard/Get/{creditCardId}");

            return result;
        }

        public async Task<CreditCard> Add(CreditCard creditCard)
        {
            CreditCard result = null;

            result = await _maarquestApiContext.HttpCreateAsync<CreditCard>("CreditCard/Add", creditCard);

            return result;
        }

        public async Task<CreditCard> Update(CreditCard creditCard)
        {
            CreditCard result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<CreditCard>("CreditCard/Update", creditCard);

            return result;
        }

        public async Task<int> Delete(int creditCardid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"CreditCard/Delete?id={creditCardid}");

            return result;
        }
    }
}
