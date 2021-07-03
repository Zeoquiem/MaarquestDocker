using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class ReceiptService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public ReceiptService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<Receipt>> GetAll()
        {
            List<Receipt> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<Receipt>>("Receipt/GetAll");

            return result;
        }

        public async Task<Receipt> Get(int receiptId)
        {
            Receipt result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<Receipt>($"Receipt/Get/{receiptId}");

            return result;
        }

        public async Task<Receipt> Add(Receipt receipt)
        {
            Receipt result = null;

            result = await _maarquestApiContext.HttpCreateAsync<Receipt>("Receipt/Add", receipt);

            return result;
        }

        public async Task<Receipt> Update(Receipt receipt)
        {
            Receipt result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<Receipt>("Receipt/Update", receipt);

            return result;
        }

        public async Task<int> Delete(int receiptid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"Receipt/Delete?id={receiptid}");

            return result;
        }
    }
}
