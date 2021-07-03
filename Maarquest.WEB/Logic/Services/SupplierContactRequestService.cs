using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class SupplierContactRequestService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public SupplierContactRequestService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<SupplierContactRequest>> GetAll()
        {
            List<SupplierContactRequest> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<SupplierContactRequest>>("SupplierContactRequest/GetAll");

            return result;
        }

        public async Task<SupplierContactRequest> Get(int supplierContactRequestId)
        {
            SupplierContactRequest result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<SupplierContactRequest>($"SupplierContactRequest/Get/{supplierContactRequestId}");

            return result;
        }

        public async Task<SupplierContactRequest> Add(SupplierContactRequest supplierContactRequest)
        {
            SupplierContactRequest result = null;

            result = await _maarquestApiContext.HttpCreateAsync<SupplierContactRequest>("SupplierContactRequest/Add", supplierContactRequest);

            return result;
        }

        public async Task<SupplierContactRequest> Update(SupplierContactRequest supplierContactRequest)
        {
            SupplierContactRequest result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<SupplierContactRequest>("SupplierContactRequest/Update", supplierContactRequest);

            return result;
        }

        public async Task<int> Delete(int supplierContactRequestid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"SupplierContactRequest/Delete?id={supplierContactRequestid}");

            return result;
        }
    }
}
