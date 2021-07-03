using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class PromotionCustomerService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public PromotionCustomerService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<PromotionCustomer>> GetAll()
        {
            List<PromotionCustomer> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<PromotionCustomer>>("PromotionCustomer/GetAll");

            return result;
        }

        public async Task<List<PromotionCustomer>> GetAllFromPromotion(int promotionId)
        {
            List<PromotionCustomer> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<PromotionCustomer>>($"PromotionCustomer/GetAllFromPromotion/{promotionId}");

            return result;
        }

        public async Task<List<PromotionCustomer>> GetAllFromCustomer(int customerId)
        {
            List<PromotionCustomer> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<PromotionCustomer>>($"PromotionCustomer/GetAllFromProduct/{customerId}");

            return result;
        }

        public async Task<PromotionCustomer> Get(int promotionId, int customerId)
        {
            PromotionCustomer result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<PromotionCustomer>($"PromotionCustomer/Get?promotionId={promotionId}&customerId={customerId}");

            return result;
        }

        public async Task<PromotionCustomer> Add(PromotionCustomer promotionCustomer)
        {
            PromotionCustomer result = null;

            result = await _maarquestApiContext.HttpCreateAsync<PromotionCustomer>("PromotionCustomer/Add", promotionCustomer);

            return result;
        }

        public async Task<PromotionCustomer> UpdatePromotion(PromotionCustomer promotionCustomer, int newPromotionId)
        {
            PromotionCustomer result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<PromotionCustomer>($"PromotionCustomer/UpdatePromotion?newPromotionId={newPromotionId}", promotionCustomer);

            return result;
        }

        public async Task<PromotionCustomer> UpdateCustomer(PromotionCustomer promotionCustomer, int newCustomerId)
        {
            PromotionCustomer result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<PromotionCustomer>($"PromotionCustomer/UpdateProduct?newCustomerId={newCustomerId}", promotionCustomer);

            return result;
        }

        public async Task<int> Delete(int promotionId, int customerId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"PromotionCustomer/Delete?promotionId={promotionId}&customerId={customerId}");

            return result;
        }

        public async Task<int> DeleteAllFromPromotion(int promotionId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"PromotionCustomer/DeleteAllFromPromotion?promotionId={promotionId}");

            return result;
        }

        public async Task<int> DeleteAllFromCustomer(int customerId)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"PromotionCustomer/DeleteAllFromProduct?customerId={customerId}");

            return result;
        }
    }
}
