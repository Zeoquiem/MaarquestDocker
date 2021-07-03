using CustomerModel = Maarquest.WEB.Logic.Models.Customer;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class CustomerService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public CustomerService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<CustomerModel>> GetAll()
        {
            List<CustomerModel> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<CustomerModel>>("Customer/GetAll");

            return result;
        }

        public async Task<CustomerModel> Get(int customerId)
        {
            CustomerModel result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<CustomerModel>($"Customer/Get/{customerId}");

            return result;
        }

        public async Task<CustomerModel> Add(CustomerModel customer)
        {
            CustomerModel result = null;

            result = await _maarquestApiContext.HttpCreateAsync<CustomerModel>("Customer/Add", customer);

            return result;
        }

        public async Task<CustomerModel> Update(CustomerModel customer)
        {
            CustomerModel result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<CustomerModel>("Customer/Update", customer);

            return result;
        }

        public async Task<int> Delete(int customerid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"Customer/Delete?id={customerid}");

            return result;
        }
    }
}
