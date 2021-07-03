using Maarquest.WEB.Logic.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maarquest.WEB.Logic.Services
{
    public class SupplierProductRequestService
    {
        private readonly IMaarquestApiContext _maarquestApiContext;


        public SupplierProductRequestService(IMaarquestApiContext maarquestApiContext)
        {
            _maarquestApiContext = maarquestApiContext;
        }

        public async Task<List<SupplierProductRequest>> GetAll()
        {
            List<SupplierProductRequest> result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<List<SupplierProductRequest>>("SupplierProductRequest/GetAll");

            return result;
        }

        public async Task<SupplierProductRequest> Get(int supplierProductRequestId)
        {
            SupplierProductRequest result = null;

            result = await _maarquestApiContext.HttpGetItemAsync<SupplierProductRequest>($"SupplierProductRequest/Get/{supplierProductRequestId}");

            return result;
        }

        public async Task<SupplierProductRequest> Add(SupplierProductRequest supplierProductRequest)
        {
            SupplierProductRequest result = null;

            result = await _maarquestApiContext.HttpCreateAsync<SupplierProductRequest>("SupplierProductRequest/Add", supplierProductRequest);

            return result;
        }

        public async Task<SupplierProductRequest> Update(SupplierProductRequest supplierProductRequest)
        {
            SupplierProductRequest result = null;

            result = await _maarquestApiContext.HttpUpdateAsync<SupplierProductRequest>("SupplierProductRequest/Update", supplierProductRequest);

            return result;
        }

        public async Task<int> Delete(int supplierProductRequestid)
        {
            int result = 0;

            result = await _maarquestApiContext.HttpDeleteAsync($"SupplierProductRequest/Delete?id={supplierProductRequestid}");

            return result;
        }
    }
}
